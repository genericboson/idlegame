using Godot;
using System;

public partial class Car : CharacterBody2D
{
	public const float SPEED = 300.0f;
	public const float VELOCITY = 200.0f;

	public override void _PhysicsProcess(double delta)
	{
		Vector2 velocity = Velocity;

		if(Input.IsActionPressed("up"))
		{
			Velocity = new Vector2(Velocity.X, -VELOCITY);
		}

		if (Input.IsActionPressed("down"))
		{
			Velocity = new Vector2(Velocity.X, VELOCITY);
		}

		if (Input.IsActionPressed("left"))
		{
			Velocity = new Vector2(-VELOCITY, Velocity.Y);
		}

		if (Input.IsActionPressed("right"))
		{
			Velocity = new Vector2(VELOCITY, Velocity.Y);
		}

		//////////////////////////////

		if (Input.IsActionJustReleased("up"))
		{
			Velocity = new Vector2(Velocity.X, 0);
		}

		if (Input.IsActionJustReleased("down"))
		{
			Velocity = new Vector2(Velocity.X, 0);
		}

		if (Input.IsActionJustReleased("left"))
		{
			Velocity = new Vector2(0, Velocity.Y);
		}

		if (Input.IsActionJustReleased("right"))
		{
			Velocity = new Vector2(0, Velocity.Y);
		}

		MoveAndSlide();
	}
}
