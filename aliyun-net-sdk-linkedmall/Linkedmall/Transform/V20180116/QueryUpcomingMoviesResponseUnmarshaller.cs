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
    public class QueryUpcomingMoviesResponseUnmarshaller
    {
        public static QueryUpcomingMoviesResponse Unmarshall(UnmarshallerContext context)
        {
			QueryUpcomingMoviesResponse queryUpcomingMoviesResponse = new QueryUpcomingMoviesResponse();

			queryUpcomingMoviesResponse.HttpResponse = context.HttpResponse;
			queryUpcomingMoviesResponse.RequestId = context.StringValue("QueryUpcomingMovies.RequestId");
			queryUpcomingMoviesResponse.Code = context.StringValue("QueryUpcomingMovies.Code");
			queryUpcomingMoviesResponse.Message = context.StringValue("QueryUpcomingMovies.Message");
			queryUpcomingMoviesResponse.SubCode = context.StringValue("QueryUpcomingMovies.SubCode");
			queryUpcomingMoviesResponse.SubMessage = context.StringValue("QueryUpcomingMovies.SubMessage");
			queryUpcomingMoviesResponse.LogsId = context.StringValue("QueryUpcomingMovies.LogsId");
			queryUpcomingMoviesResponse.Success = context.BooleanValue("QueryUpcomingMovies.Success");
			queryUpcomingMoviesResponse.TotalCount = context.LongValue("QueryUpcomingMovies.TotalCount");

			List<QueryUpcomingMoviesResponse.QueryUpcomingMovies_Movie> queryUpcomingMoviesResponse_movies = new List<QueryUpcomingMoviesResponse.QueryUpcomingMovies_Movie>();
			for (int i = 0; i < context.Length("QueryUpcomingMovies.Movies.Length"); i++) {
				QueryUpcomingMoviesResponse.QueryUpcomingMovies_Movie movie = new QueryUpcomingMoviesResponse.QueryUpcomingMovies_Movie();
				movie.Id = context.LongValue("QueryUpcomingMovies.Movies["+ i +"].Id");
				movie.BackgroundPicture = context.StringValue("QueryUpcomingMovies.Movies["+ i +"].BackgroundPicture");
				movie.Highlight = context.StringValue("QueryUpcomingMovies.Movies["+ i +"].Highlight");
				movie.OpenTime = context.StringValue("QueryUpcomingMovies.Movies["+ i +"].OpenTime");
				movie.MovieTypeList = context.StringValue("QueryUpcomingMovies.Movies["+ i +"].MovieTypeList");
				movie.MovieVersion = context.StringValue("QueryUpcomingMovies.Movies["+ i +"].MovieVersion");
				movie.Description = context.StringValue("QueryUpcomingMovies.Movies["+ i +"].Description");
				movie.Poster = context.StringValue("QueryUpcomingMovies.Movies["+ i +"].Poster");
				movie.TrailerList = context.StringValue("QueryUpcomingMovies.Movies["+ i +"].TrailerList");
				movie.OpenDay = context.StringValue("QueryUpcomingMovies.Movies["+ i +"].OpenDay");
				movie.Duration = context.LongValue("QueryUpcomingMovies.Movies["+ i +"].Duration");
				movie.Language = context.StringValue("QueryUpcomingMovies.Movies["+ i +"].Language");
				movie.Country = context.StringValue("QueryUpcomingMovies.Movies["+ i +"].Country");
				movie.Type = context.StringValue("QueryUpcomingMovies.Movies["+ i +"].Type");
				movie.LeadingRole = context.StringValue("QueryUpcomingMovies.Movies["+ i +"].LeadingRole");
				movie.Director = context.StringValue("QueryUpcomingMovies.Movies["+ i +"].Director");
				movie.MovieNameEn = context.StringValue("QueryUpcomingMovies.Movies["+ i +"].MovieNameEn");
				movie.MovieName = context.StringValue("QueryUpcomingMovies.Movies["+ i +"].MovieName");
				movie.Remark = context.StringValue("QueryUpcomingMovies.Movies["+ i +"].Remark");

				queryUpcomingMoviesResponse_movies.Add(movie);
			}
			queryUpcomingMoviesResponse.Movies = queryUpcomingMoviesResponse_movies;
        
			return queryUpcomingMoviesResponse;
        }
    }
}
