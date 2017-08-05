namespace AssassinSteed.Actor
{
    /// <summary>
    /// Anything that can move on the ground should implement this interface
    /// </summary>
    public interface IGroundMovementControl
    {
        /// <summary>
        /// Move the character forward at a speed between 0 and 1 (max speed)
        /// </summary>
        /// <param name="degree">Percentage of max speed to move by</param>
        void MoveForward(float degree);

        /// <summary>
        /// Move the character backward at a speed between 0 and 1 (max speed)
        /// </summary>
        /// <param name="degree">Percentage of max speed to move by</param>
        void MoveBackward(float degree);
        
        /// <summary>
        /// Move the character left at a speed between 0 and 1 (max speed)
        /// </summary>
        /// <param name="degree">Percentage of max speed to move by</param>
        void MoveLeft(float degree);

        /// <summary>
        /// Move the character right at a speed between 0 and 1 (max speed)
        /// </summary>
        /// <param name="degree">Percentage of max speed to move by</param>
        void MoveRight(float degree);

        /// <summary>
        /// Rotate the character either left or right
        /// </summary>
        /// <param name="degree"></param>
        void Rotate(float degree);

    }
}