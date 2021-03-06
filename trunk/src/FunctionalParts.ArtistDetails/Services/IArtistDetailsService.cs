﻿using SevenDigital.Api.Schema.ArtistEndpoint;

namespace FunctionalParts.ArtistDetails.Services
{
	public interface IArtistDetailsService
	{
		Artist GetArtist(string artistName);
		ArtistReleases GetArtistReleases(int artistId);
	}
}