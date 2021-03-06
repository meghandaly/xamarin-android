namespace Xamarin.Android.Prepare
{
	public enum KnownConditions
	{
		/// <summary>
		///   If this condition is set, then Mono upgrade will be performed. It is unset by default because Mono upgrade
		///   requires application restart or we may crash. Default: unset. <see cref="Scenario_UpdateMono" />
		/// </summary>
		AllowMonoUpdate,

		/// <summary>
		///   If set, the outdated or missing programs will be installed. Default: set.
		/// </summary>
		AllowProgramInstallation,

		/// <summary>
		///   Ignore missing programs and do not signal an error. This is useful in scenarios when we want to update
		///   only a single program (e.g. the UpdateMono scenario) but not the rest. Default: unset. <see cref="Scenario_UpdateMono" />
		/// </summary>
		IgnoreMissingPrograms,

		/// <summary>
		///   If set, will cause checkout of the commercial dependencies mentioned in the `.external` file at
		///   the top of the repository. Default: unset
		/// </summary>
		IncludeCommercial,

		/// <summary>
		///   If this condition is set, the current scenario will take care of missing essential (<see
		///   cref="EssentialTools"/>) programs should they be missing.
		/// </summary>
		EnsureEssential,
	}
}
