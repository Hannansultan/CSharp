using System;
using System.Diagnostics;
using System.Drawing;
using System.Collections.Generic;

#region emgu cv libs
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Features2D;
using Emgu.CV.Structure;
using Emgu.CV.Util;
using Emgu.CV.XFeatures2D;
using System.Linq;

#endregion

namespace F_ChannelFinder
{
    public class PerfromSurf
    { 
        // ------------------------------------ Modify the algo to some extent and found a way to check the most matched logo---- ||
        // ------------------------------------ Most difficult program i have delt wiht :( but have done it with WIth help of ALLAH ALMIGHT and HARDWORK :)---||
        //-------------------------------------                             cha gya larky to :P           ---- bs kam krta reh --- ||

         #region required data
        public static bool goodMatch = false;
        public static double time;
        public static string obsrvedPoints;
        public static string matchedPoints;
        public static double matchesNew;
        public static double homographySizeHeight;
        public static double homographySizeWidht;
        public static double percentage, matchedCount;
        public static int rectangle, count = 0;
        public static int k = 2;
        public static double uniquenessThreshold = .5;
        public static double hessianThresh = 800;
        public static double ployArea;
        public static Graphics paper;

        #endregion

        public static bool FindMatch(Mat modelImage, Mat observedImage, out long matchTime, out VectorOfKeyPoint modelKeyPoints, out VectorOfKeyPoint observedKeyPoints, VectorOfVectorOfDMatch matches, out Mat mask, out Mat homography)
        {
            //445

            Stopwatch watch;
            homography = null;

            modelKeyPoints = new VectorOfKeyPoint();
            observedKeyPoints = new VectorOfKeyPoint();


            using (UMat uModelImage = modelImage.ToUMat(AccessType.Read))
            using (UMat uObservedImage = observedImage.ToUMat(AccessType.Read))
            {
                SURF surfCPU = new SURF(hessianThresh);
                //extract features from the object image
                UMat modelDescriptors = new UMat();
                surfCPU.DetectAndCompute(uModelImage, null, modelKeyPoints, modelDescriptors, false);

                watch = Stopwatch.StartNew();

                // extract features from the observed image
                UMat observedDescriptors = new UMat();
                surfCPU.DetectAndCompute(uObservedImage, null, observedKeyPoints, observedDescriptors, false);
                BFMatcher matcher = new BFMatcher(DistanceType.L2);
                matcher.Add(modelDescriptors);

                matcher.KnnMatch(observedDescriptors, matches, k, null);
                mask = new Mat(matches.Size, 1, DepthType.Cv8U, 1);
                mask.SetTo(new MCvScalar(255));
                Features2DToolbox.VoteForUniqueness(matches, uniquenessThreshold, mask);



                int nonZeroCount = CvInvoke.CountNonZero(mask);
                if (nonZeroCount >= 10)
                {
                    nonZeroCount = Features2DToolbox.VoteForSizeAndOrientation(modelKeyPoints, observedKeyPoints,
                        matches, mask, 1.5, 20);
                    if (nonZeroCount >= 30)
                        homography = Features2DToolbox.GetHomographyMatrixFromMatchedFeatures(modelKeyPoints,
                            observedKeyPoints, matches, mask, 2);
                    //homography.Size.Height
                    homographySizeHeight = Convert.ToDouble(homography.GetOutputArray().GetSize().Height.ToString());
                    homographySizeWidht = Convert.ToDouble(homography.Size.Width.ToString());
                    percentage = Convert.ToDouble(modelDescriptors.Size.Height.ToString()) / Convert.ToDouble(observedDescriptors.Size.Height.ToString()) * 100;
                    goodMatch = nonZeroCount >= 30 && nonZeroCount >= (observedKeyPoints.Size - modelKeyPoints.Size) / 4;
                    obsrvedPoints = (observedKeyPoints.Size.ToString());
                    matchedPoints = (modelKeyPoints.Size.ToString());
                }

                watch.Stop();
            }
            matchTime = watch.ElapsedMilliseconds;
            time = (Double)matchTime * 0.001;
            return goodMatch;
        }

        /// <summary>
        /// Draw the model image and observed image, the matched features and homography projection.
        /// </summary>
        /// <param name="modelImage">The model image</param>
        /// <param name="observedImage">The observed image</param>
        /// <param name="matchTime">The output total time for computing the homography matrix.</param>
        /// <returns>The model image and observed image, the matched features and homography projection.</returns>
        public static Mat Draw(Mat modelImage, Mat observedImage, out long matchTime)
        {
            Mat homography;
            VectorOfKeyPoint modelKeyPoints;
            VectorOfKeyPoint observedKeyPoints;

            using (VectorOfVectorOfDMatch matches = new VectorOfVectorOfDMatch())
            {
                Mat mask;
                FindMatch(modelImage, observedImage, out matchTime, out modelKeyPoints, out observedKeyPoints, matches,
                   out mask, out homography);

                //Draw the matched keypoints
                Mat result = new Mat();


                Features2DToolbox.VoteForUniqueness(matches, uniquenessThreshold, mask);
                //                Bgr res = new Bgr(Color.LightYellow);
                //Features2DToolbox.DrawKeypoints(modelImage, modelKeyPoints, observedImage, res, Features2DToolbox.KeypointDrawType.NotDrawSinglePoints);
                Features2DToolbox.DrawMatches(modelImage, modelKeyPoints, observedImage, observedKeyPoints,
                       matches, result, new MCvScalar(255, 255, 255), new MCvScalar(255, 255, 255), mask, Features2DToolbox.KeypointDrawType.NotDrawSinglePoints);



                //matchedCount = Convert.ToDouble(matches.Size.ToString());
                matchedCount = Convert.ToDouble(mask.ElementSize.ToString());
                #region draw the projected region on the image

                if (homography != null)
                {
                    //draw a rectangle along the projected model
                    Rectangle rect = new Rectangle(Point.Empty, modelImage.Size);
                    PointF[] pts = new PointF[]
                    {
                          new PointF(rect.Left, rect.Bottom),
                          new PointF(rect.Right, rect.Bottom),
                          new PointF(rect.Right, rect.Top),
                          new PointF(rect.Left, rect.Top)

                    };
                    rectangle = Convert.ToInt32(rect.Size.Height.ToString());
                    count = Convert.ToInt32(rect.Size.Width.ToString());
                    pts = CvInvoke.PerspectiveTransform(pts, homography);
                    matchesNew = 0;
                    Point[] points = Array.ConvertAll<PointF, Point>(pts, Point.Round);
                    using (VectorOfPoint vp = new VectorOfPoint(points))
                    {
                        CvInvoke.Polylines(result, vp, true, new MCvScalar(255, 0, 0, 255), 5, LineType.AntiAlias, 0);
                        //CvInvoke.DrawContours(result, vp, 2, new MCvScalar(255, 0, 0, 255), 5, LineType.AntiAlias, null);
                        Pen pen = new Pen(Color.Black);
                        //paper.DrawRectangle(pen,200,200,100,100);
                        //CvInvoke.Polylines()
                        //CvInvoke.Rectangle(result, rect, new MCvScalar(255, 0, 0, 255), 1,LineType.AntiAlias, 0);
                        //CvInvoke.HoughLines(result, vp, 10, 10, 800, 0, 0);

                    }
                    List<Point> listOfPnts = points.ToList();

                    ployArea = Area(listOfPnts);

                    result.Size.ToString();

                }


                #endregion
                //matchesNew = Convert.ToDouble(result.Data.CopyTo(array,0));

                return result;

            }

        }
        public static Double Area(List<Point> vertices)
        {
            vertices.Add(vertices[0]);
            return Math.Abs(vertices.Take(vertices.Count - 1).Select((p, i) => (p.X * vertices[i + 1].Y) - (p.Y * vertices[i + 1].X)).Sum() / 2);
        }
    }
}