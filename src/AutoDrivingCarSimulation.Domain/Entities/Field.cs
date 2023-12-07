using AutoDrivingCarSimulation.Domain.Exceptions;
using AutoDrivingCarSimulation.Shared;

namespace AutoDrivingCarSimulation.Domain.Entities
{
    public class Field
    {
        public int Width { get; }
        public int Height { get; }

        public Field(int width, int height)
        {
            ValidateDimensions(width, height);

            Width = width;
            Height = height;
        }

        private void ValidateDimensions(int width, int height)
        {
            if (width <= 0 || height <= 0)
            {
                throw new AutoDrivingCarException(Constants.FIELD_DIMENSION_ERROR);
            }
        }
    }
}
