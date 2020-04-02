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
using System.Collections.Generic;

using Aliyun.Acs.Core;

namespace Aliyun.Acs.linkedmall.Model.V20180116
{
	public class QueryUpcomingMoviesResponse : AcsResponse
	{

		private string requestId;

		private string code;

		private string message;

		private string subCode;

		private string subMessage;

		private string logsId;

		private bool? success;

		private long? totalCount;

		private List<QueryUpcomingMovies_Movie> movies;

		public string RequestId
		{
			get
			{
				return requestId;
			}
			set	
			{
				requestId = value;
			}
		}

		public string Code
		{
			get
			{
				return code;
			}
			set	
			{
				code = value;
			}
		}

		public string Message
		{
			get
			{
				return message;
			}
			set	
			{
				message = value;
			}
		}

		public string SubCode
		{
			get
			{
				return subCode;
			}
			set	
			{
				subCode = value;
			}
		}

		public string SubMessage
		{
			get
			{
				return subMessage;
			}
			set	
			{
				subMessage = value;
			}
		}

		public string LogsId
		{
			get
			{
				return logsId;
			}
			set	
			{
				logsId = value;
			}
		}

		public bool? Success
		{
			get
			{
				return success;
			}
			set	
			{
				success = value;
			}
		}

		public long? TotalCount
		{
			get
			{
				return totalCount;
			}
			set	
			{
				totalCount = value;
			}
		}

		public List<QueryUpcomingMovies_Movie> Movies
		{
			get
			{
				return movies;
			}
			set	
			{
				movies = value;
			}
		}

		public class QueryUpcomingMovies_Movie
		{

			private long? id;

			private string backgroundPicture;

			private string highlight;

			private string openTime;

			private string movieTypeList;

			private string movieVersion;

			private string description;

			private string poster;

			private string trailerList;

			private string openDay;

			private long? duration;

			private string language;

			private string country;

			private string type;

			private string leadingRole;

			private string director;

			private string movieNameEn;

			private string movieName;

			private string remark;

			public long? Id
			{
				get
				{
					return id;
				}
				set	
				{
					id = value;
				}
			}

			public string BackgroundPicture
			{
				get
				{
					return backgroundPicture;
				}
				set	
				{
					backgroundPicture = value;
				}
			}

			public string Highlight
			{
				get
				{
					return highlight;
				}
				set	
				{
					highlight = value;
				}
			}

			public string OpenTime
			{
				get
				{
					return openTime;
				}
				set	
				{
					openTime = value;
				}
			}

			public string MovieTypeList
			{
				get
				{
					return movieTypeList;
				}
				set	
				{
					movieTypeList = value;
				}
			}

			public string MovieVersion
			{
				get
				{
					return movieVersion;
				}
				set	
				{
					movieVersion = value;
				}
			}

			public string Description
			{
				get
				{
					return description;
				}
				set	
				{
					description = value;
				}
			}

			public string Poster
			{
				get
				{
					return poster;
				}
				set	
				{
					poster = value;
				}
			}

			public string TrailerList
			{
				get
				{
					return trailerList;
				}
				set	
				{
					trailerList = value;
				}
			}

			public string OpenDay
			{
				get
				{
					return openDay;
				}
				set	
				{
					openDay = value;
				}
			}

			public long? Duration
			{
				get
				{
					return duration;
				}
				set	
				{
					duration = value;
				}
			}

			public string Language
			{
				get
				{
					return language;
				}
				set	
				{
					language = value;
				}
			}

			public string Country
			{
				get
				{
					return country;
				}
				set	
				{
					country = value;
				}
			}

			public string Type
			{
				get
				{
					return type;
				}
				set	
				{
					type = value;
				}
			}

			public string LeadingRole
			{
				get
				{
					return leadingRole;
				}
				set	
				{
					leadingRole = value;
				}
			}

			public string Director
			{
				get
				{
					return director;
				}
				set	
				{
					director = value;
				}
			}

			public string MovieNameEn
			{
				get
				{
					return movieNameEn;
				}
				set	
				{
					movieNameEn = value;
				}
			}

			public string MovieName
			{
				get
				{
					return movieName;
				}
				set	
				{
					movieName = value;
				}
			}

			public string Remark
			{
				get
				{
					return remark;
				}
				set	
				{
					remark = value;
				}
			}
		}
	}
}
