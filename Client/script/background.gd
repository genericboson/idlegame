extends ParallaxBackground

const speed = 200

# Called every frame. 'delta' is the elapsed time since the previous frame.
func _process(delta: float) -> void:
	scroll_offset.y += delta * speed
	return
