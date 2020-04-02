/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
using System;
using System.Collections.Generic;

using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.linkedmall.Model.V20180116;

namespace Aliyun.Acs.linkedmall.Transform.V20180116
{
    public class QueryHotMoviesResponseUnmarshaller
    {
        public static QueryHotMoviesResponse Unmarshall(UnmarshallerContext context)
        {
			QueryHotMoviesResponse queryHotMoviesResponse = new QueryHotMoviesResponse();

			queryHotMoviesResponse.HttpResponse = context.HttpResponse;
			queryHotMoviesResponse.RequestId = context.StringValue("QueryHotMovies.RequestId");
			queryHotMoviesResponse.LogsId = context.StringValue("QueryHotMovies.LogsId");
			queryHotMoviesResponse.SubCode = context.StringValue("QueryHotMovies.SubCode");
			queryHotMoviesResponse.SubMessage = context.StringValue("QueryHotMovies.SubMessage");
			queryHotMoviesResponse.Code = context.StringValue("QueryHotMovies.Code");
			queryHotMoviesResponse.Success = context.BooleanValue("QueryHotMovies.Success");
			queryHotMoviesResponse.Message = context.StringValue("QueryHotMovies.Message");

			List<QueryHotMoviesResponse.QueryHotMovies_Movie> queryHotMoviesResponse_movies = new List<QueryHotMoviesResponse.QueryHotMovies_Movie>();
			for (int i = 0; i < context.Length("QueryHotMovies.Movies.Length"); i++) {
				QueryHotMoviesResponse.QueryHotMovies_Movie movie = new QueryHotMoviesResponse.QueryHotMovies_Movie();
				movie.BackgroundPicture = context.StringValue("QueryHotMovies.Movies["+ i +"].BackgroundPicture");
				movie.Country = context.StringValue("QueryHotMovies.Movies["+ i +"].Country");
				movie.Description = context.StringValue("QueryHotMovies.Movies["+ i +"].Description");
				movie.Director = context.StringValue("QueryHotMovies.Movies["+ i +"].Director");
				movie.Duration = context.LongValue("QueryHotMovies.Movies["+ i +"].Duration");
				movie.Highlight = context.StringValue("QueryHotMovies.Movies["+ i +"].Highlight");
				movie.Id = context.LongValue("QueryHotMovies.Movies["+ i +"].Id");
				movie.Language = context.StringValue("QueryHotMovies.Movies["+ i +"].Language");
				movie.LeadingRole = context.StringValue("QueryHotMovies.Movies["+ i +"].LeadingRole");
				movie.OpenDay = context.StringValue("QueryHotMovies.Movies["+ i +"].OpenDay");
				movie.OpenTime = context.StringValue("QueryHotMovies.Movies["+ i +"].OpenTime");
				movie.Poster = context.StringValue("QueryHotMovies.Movies["+ i +"].Poster");
				movie.Remark = context.StringValue("QueryHotMovies.Movies["+ i +"].Remark");
				movie.MovieVersion = context.StringValue("QueryHotMovies.Movies["+ i +"].MovieVersion");
				movie.MovieName = context.StringValue("QueryHotMovies.Movies["+ i +"].MovieName");
				movie.MovieNameEn = context.StringValue("QueryHotMovies.Movies["+ i +"].MovieNameEn");
				movie.Type = context.StringValue("QueryHotMovies.Movies["+ i +"].Type");

				List<string> movie_movieTypeList = new List<string>();
				for (int j = 0; j < context.Length("QueryHotMovies.Movies["+ i +"].MovieTypeList.Length"); j++) {
					movie_movieTypeList.Add(context.StringValue("QueryHotMovies.Movies["+ i +"].MovieTypeList["+ j +"]"));
				}
				movie.MovieTypeList = movie_movieTypeList;

				List<string> movie_trailerList = new List<string>();
				for (int j = 0; j < context.Length("QueryHotMovies.Movies["+ i +"].TrailerList.Length"); j++) {
					movie_trailerList.Add(context.StringValue("QueryHotMovies.Movies["+ i +"].TrailerList["+ j +"]"));
				}
				movie.TrailerList = movie_trailerList;

				queryHotMoviesResponse_movies.Add(movie);
			}
			queryHotMoviesResponse.Movies = queryHotMoviesResponse_movies;
        
			return queryHotMoviesResponse;
        }
    }
}
