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
	public class QueryHotMoviesResponse : AcsResponse
	{

		private string requestId;

		private string logsId;

		private string subCode;

		private string subMessage;

		private string code;

		private bool? success;

		private string message;

		private List<QueryHotMovies_Movie> movies;

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

		public List<QueryHotMovies_Movie> Movies
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

		public class QueryHotMovies_Movie
		{

			private string backgroundPicture;

			private string country;

			private string description;

			private string director;

			private long? duration;

			private string highlight;

			private long? id;

			private string language;

			private string leadingRole;

			private string openDay;

			private string openTime;

			private string poster;

			private string remark;

			private string movieVersion;

			private string movieName;

			private string movieNameEn;

			private string type;

			private List<string> movieTypeList;

			private List<string> trailerList;

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

			public List<string> MovieTypeList
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

			public List<string> TrailerList
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
		}
	}
}
