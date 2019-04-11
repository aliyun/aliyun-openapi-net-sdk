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

namespace Aliyun.Acs.vod.Model.V20170321
{
	public class DescribePlayUserTotalResponse : AcsResponse
	{

		private string requestId;

		private List<DescribePlayUserTotal_UserPlayStatisTotal> userPlayStatisTotals;

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

		public List<DescribePlayUserTotal_UserPlayStatisTotal> UserPlayStatisTotals
		{
			get
			{
				return userPlayStatisTotals;
			}
			set	
			{
				userPlayStatisTotals = value;
			}
		}

		public class DescribePlayUserTotal_UserPlayStatisTotal
		{

			private string date;

			private string playDuration;

			private string playRange;

			private DescribePlayUserTotal_VV vV;

			private DescribePlayUserTotal_UV uV;

			public string Date
			{
				get
				{
					return date;
				}
				set	
				{
					date = value;
				}
			}

			public string PlayDuration
			{
				get
				{
					return playDuration;
				}
				set	
				{
					playDuration = value;
				}
			}

			public string PlayRange
			{
				get
				{
					return playRange;
				}
				set	
				{
					playRange = value;
				}
			}

			public DescribePlayUserTotal_VV VV
			{
				get
				{
					return vV;
				}
				set	
				{
					vV = value;
				}
			}

			public DescribePlayUserTotal_UV UV
			{
				get
				{
					return uV;
				}
				set	
				{
					uV = value;
				}
			}

			public class DescribePlayUserTotal_VV
			{

				private string android;

				private string iOS;

				private string flash;

				private string hTML5;

				public string Android
				{
					get
					{
						return android;
					}
					set	
					{
						android = value;
					}
				}

				public string IOS
				{
					get
					{
						return iOS;
					}
					set	
					{
						iOS = value;
					}
				}

				public string Flash
				{
					get
					{
						return flash;
					}
					set	
					{
						flash = value;
					}
				}

				public string HTML5
				{
					get
					{
						return hTML5;
					}
					set	
					{
						hTML5 = value;
					}
				}
			}

			public class DescribePlayUserTotal_UV
			{

				private string android;

				private string iOS;

				private string flash;

				private string hTML5;

				public string Android
				{
					get
					{
						return android;
					}
					set	
					{
						android = value;
					}
				}

				public string IOS
				{
					get
					{
						return iOS;
					}
					set	
					{
						iOS = value;
					}
				}

				public string Flash
				{
					get
					{
						return flash;
					}
					set	
					{
						flash = value;
					}
				}

				public string HTML5
				{
					get
					{
						return hTML5;
					}
					set	
					{
						hTML5 = value;
					}
				}
			}
		}
	}
}
