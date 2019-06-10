using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerProgress
{
	// Mode of the level
	public LevelMode levelMode;

	// Number of the level
	public int levelNumber;

	// Percentage of the star that made by player of a completed level.
	public float starPercent;

	// Best time is minimum passed time of a completed level.
	public float bestTime;

	// The minimum mistake made by the player in a completed level is best try for that level.
	public int bestTry;

	// The maximum opened card by the player in a completed level is best count for that level.
	public int bestCount;

	// Whether level completed or it's not completed.
	public bool completed;

	// Whether level lock opened or it's not opened.
	public bool locked;

	public PlayerProgress(LevelMode levelMode, int levelNumber, float starPercent, 
		float bestTime, int bestTry, int bestCount, bool cleared, bool locked)
	{
		this.levelMode   = levelMode;
		this.levelNumber = levelNumber;
		this.starPercent = starPercent;
		this.bestTime    = bestTime;
		this.bestTry     = bestTry;
		this.bestCount   = bestCount;
		this.completed   = cleared;
		this.locked      = locked;
	}
}
