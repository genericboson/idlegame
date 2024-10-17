using Godot;
using System;

public partial class Background : ParallaxBackground
{
	private static int SPEED = 200;

	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		ScrollOffset += new Vector2(0, SPEED * (float)delta);
	}
}
