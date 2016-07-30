using UnityEngine;
using System.Collections;
using UnityStandardAssets.Characters.FirstPerson;

public static class Globals
{
    public static GameObject MainPlayer { get; set; }

    public static FPSInteractiveController PlayerController { get; set; }

    public static FirstPersonController FPSController { get; set; }

    public static DialogController Dialog { get; set; }
}
