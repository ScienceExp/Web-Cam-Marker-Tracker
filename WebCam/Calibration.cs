using System;
using System.Drawing;
using System.Windows.Forms;

namespace WebCam
{
    public class Calibration
    {
        #region declerations
        public bool EnableContinualCalibration = true;
        /// <summary>How far tracker must move in the x or y direction to be considered an actual move</summary>
        public float deadZone = 2;

        /// <summary>The x offset of the 2 markers while in a neutral head position</summary>
        float offsetx = 0;
        /// <summary>The y offset of the 2 markers while in a neutral head position</summary>
        float offsety = 0;

        /// <summary>This is the total distance between markers in the x direction. Value will be negative.</summary>
        float MaxLeft = 0;
        /// <summary>This is the total distance between markers in the x direction. Value will be positive</summary>
        float MaxRight = 0;
        /// <summary>This is the total distance between markers in the y direction. Value will be smaller than MaxDown.</summary>
        float MaxUp = 0;
        /// <summary>This is the total distance between markers in the y direction. Value will be larger than MaxUp</summary>
        float MaxDown = 0;

        /// <summary>This is the amount of pixels that make up the 'left' rotation. It takes into account the offset.</summary>
        float amountLeft;
        /// <summary>This is the amount of pixels that make up the 'right' rotation. It takes into account the offset.</summary>
        float amountRight;
        /// <summary>This is the amount of pixels that make up the 'up' rotation. It takes into account the offset.</summary>
        float amountUp;
        /// <summary>This is the amount of pixels that make up the 'down' rotation. It takes into account the offset.</summary>
        float amountDown;
        #endregion 

        /// <summary>Sets the offsets while the head is in a neutral position</summary>
        public void SetCenter(Point topMarker, Point bottomMarker)
        {
            offsetx = topMarker.X - bottomMarker.X;
            offsety = topMarker.Y - bottomMarker.Y;
            Console.WriteLine("offsetX: " + offsetx + " offsetY: " + offsety);
        }

        public void SetMaxLeftRotation(Point topMarker, Point bottomMarker)
        {
            MaxLeft = topMarker.X - bottomMarker.X; //should return a negative number
            amountLeft = MaxLeft - offsetx;

            Console.WriteLine("MaxLeft: " + MaxLeft);
        }

        public void SetMaxRightRotation(Point topMarker, Point bottomMarker)
        {
            MaxRight = topMarker.X - bottomMarker.X; //should return a positive number
            amountRight = MaxRight - offsetx;
            Console.WriteLine("MaxRight: " + MaxRight);
        }

        public void SetMaxUpRotation(Point topMarker, Point bottomMarker)
        {
            MaxUp = topMarker.Y - bottomMarker.Y; //should return a positive number (but smaller than MaxDown)
            amountUp = Math.Abs(offsety) - MaxUp;
            Console.WriteLine("MaxUp: " + MaxUp);
        }

        public void SetMaxDownRotation(Point topMarker, Point bottomMarker)
        {
            MaxDown = topMarker.Y - bottomMarker.Y; //should return a positive number
            amountDown = MaxDown - Math.Abs(offsety);
            Console.WriteLine("MaxDown: " + MaxDown);
        }

        /// <returns>The percent of maximum rotation. (1 = 100%)</returns>
        public float GetRotationLeftRight(Point topMarker, Point bottomMarker)
        {
            float currentDistance = (topMarker.X - bottomMarker.X);

            #region Continual Calibration
            if (EnableContinualCalibration)
            {
                if (currentDistance < MaxLeft)
                {
                    MaxLeft = currentDistance;
                    amountLeft = MaxLeft - offsetx;
                }
                else if (currentDistance > MaxRight)
                {
                    MaxRight = currentDistance;
                    amountRight = MaxRight - offsetx;
                }
            }
            #endregion

            currentDistance -= offsetx;
            if (currentDistance < 0)
                return (currentDistance / amountLeft)* -1f;
            else
                return (currentDistance / amountRight);

        }

        /// <returns>The percent of maximum rotation.(1 = 100%)</returns>
        public float GetRotationUpDown(Point topMarker, Point bottomMarker)
        {
            float offset = Math.Abs(offsety);
            float currentDistance = (topMarker.Y - bottomMarker.Y);

            #region Continual Calibration
            if (EnableContinualCalibration)
            {
                if (currentDistance < MaxUp)
                {
                    MaxUp = currentDistance; //should return a positive number (but smaller than MaxDown)
                    amountUp = offset - MaxUp;
                }
                else if (currentDistance > MaxDown)
                {
                    MaxDown = currentDistance; //should return a positive number
                    amountDown = MaxDown - offset;
                }
            }
            #endregion 

            currentDistance -= offset;
            if (currentDistance < 0)
                return currentDistance / amountUp;
            else
                return currentDistance / amountDown;
        }
    }
}
