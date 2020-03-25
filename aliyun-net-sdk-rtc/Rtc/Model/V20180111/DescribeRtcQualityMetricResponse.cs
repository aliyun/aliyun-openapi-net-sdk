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

namespace Aliyun.Acs.rtc.Model.V20180111
{
	public class DescribeRtcQualityMetricResponse : AcsResponse
	{

		private string requestId;

		private DescribeRtcQualityMetric_QualityMetric qualityMetric;

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

		public DescribeRtcQualityMetric_QualityMetric QualityMetric
		{
			get
			{
				return qualityMetric;
			}
			set	
			{
				qualityMetric = value;
			}
		}

		public class DescribeRtcQualityMetric_QualityMetric
		{

			private DescribeRtcQualityMetric_SubInfo subInfo;

			private DescribeRtcQualityMetric_PubInfo pubInfo;

			public DescribeRtcQualityMetric_SubInfo SubInfo
			{
				get
				{
					return subInfo;
				}
				set	
				{
					subInfo = value;
				}
			}

			public DescribeRtcQualityMetric_PubInfo PubInfo
			{
				get
				{
					return pubInfo;
				}
				set	
				{
					pubInfo = value;
				}
			}

			public class DescribeRtcQualityMetric_SubInfo
			{

				private List<DescribeRtcQualityMetric_DataItem> data;

				private List<DescribeRtcQualityMetric_EventsItem> events;

				private DescribeRtcQualityMetric_User user;

				public List<DescribeRtcQualityMetric_DataItem> Data
				{
					get
					{
						return data;
					}
					set	
					{
						data = value;
					}
				}

				public List<DescribeRtcQualityMetric_EventsItem> Events
				{
					get
					{
						return events;
					}
					set	
					{
						events = value;
					}
				}

				public DescribeRtcQualityMetric_User User
				{
					get
					{
						return user;
					}
					set	
					{
						user = value;
					}
				}

				public class DescribeRtcQualityMetric_DataItem
				{

					private string time;

					private DescribeRtcQualityMetric_Fps fps;

					private DescribeRtcQualityMetric_Resolution resolution;

					private DescribeRtcQualityMetric_BitRate bitRate;

					private DescribeRtcQualityMetric_Network network;

					public string Time
					{
						get
						{
							return time;
						}
						set	
						{
							time = value;
						}
					}

					public DescribeRtcQualityMetric_Fps Fps
					{
						get
						{
							return fps;
						}
						set	
						{
							fps = value;
						}
					}

					public DescribeRtcQualityMetric_Resolution Resolution
					{
						get
						{
							return resolution;
						}
						set	
						{
							resolution = value;
						}
					}

					public DescribeRtcQualityMetric_BitRate BitRate
					{
						get
						{
							return bitRate;
						}
						set	
						{
							bitRate = value;
						}
					}

					public DescribeRtcQualityMetric_Network Network
					{
						get
						{
							return network;
						}
						set	
						{
							network = value;
						}
					}

					public class DescribeRtcQualityMetric_Fps
					{

						private long? small;

						private long? large;

						private long? super;

						private long? share;

						public long? Small
						{
							get
							{
								return small;
							}
							set	
							{
								small = value;
							}
						}

						public long? Large
						{
							get
							{
								return large;
							}
							set	
							{
								large = value;
							}
						}

						public long? Super
						{
							get
							{
								return super;
							}
							set	
							{
								super = value;
							}
						}

						public long? Share
						{
							get
							{
								return share;
							}
							set	
							{
								share = value;
							}
						}
					}

					public class DescribeRtcQualityMetric_Resolution
					{

						private long? small;

						private long? large;

						private long? super;

						private long? share;

						public long? Small
						{
							get
							{
								return small;
							}
							set	
							{
								small = value;
							}
						}

						public long? Large
						{
							get
							{
								return large;
							}
							set	
							{
								large = value;
							}
						}

						public long? Super
						{
							get
							{
								return super;
							}
							set	
							{
								super = value;
							}
						}

						public long? Share
						{
							get
							{
								return share;
							}
							set	
							{
								share = value;
							}
						}
					}

					public class DescribeRtcQualityMetric_BitRate
					{

						private long? audio;

						private long? small;

						private long? large;

						private long? super;

						private long? share;

						public long? Audio
						{
							get
							{
								return audio;
							}
							set	
							{
								audio = value;
							}
						}

						public long? Small
						{
							get
							{
								return small;
							}
							set	
							{
								small = value;
							}
						}

						public long? Large
						{
							get
							{
								return large;
							}
							set	
							{
								large = value;
							}
						}

						public long? Super
						{
							get
							{
								return super;
							}
							set	
							{
								super = value;
							}
						}

						public long? Share
						{
							get
							{
								return share;
							}
							set	
							{
								share = value;
							}
						}
					}

					public class DescribeRtcQualityMetric_Network
					{

						private float? loss;

						private long? rtt;

						public float? Loss
						{
							get
							{
								return loss;
							}
							set	
							{
								loss = value;
							}
						}

						public long? Rtt
						{
							get
							{
								return rtt;
							}
							set	
							{
								rtt = value;
							}
						}
					}
				}

				public class DescribeRtcQualityMetric_EventsItem
				{

					private string time;

					private long? eventId;

					private string name;

					private string category;

					private string result;

					private string description;

					public string Time
					{
						get
						{
							return time;
						}
						set	
						{
							time = value;
						}
					}

					public long? EventId
					{
						get
						{
							return eventId;
						}
						set	
						{
							eventId = value;
						}
					}

					public string Name
					{
						get
						{
							return name;
						}
						set	
						{
							name = value;
						}
					}

					public string Category
					{
						get
						{
							return category;
						}
						set	
						{
							category = value;
						}
					}

					public string Result
					{
						get
						{
							return result;
						}
						set	
						{
							result = value;
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
				}

				public class DescribeRtcQualityMetric_User
				{

					private string userId;

					private string sDKVersion;

					private string oS;

					private string province;

					public string UserId
					{
						get
						{
							return userId;
						}
						set	
						{
							userId = value;
						}
					}

					public string SDKVersion
					{
						get
						{
							return sDKVersion;
						}
						set	
						{
							sDKVersion = value;
						}
					}

					public string OS
					{
						get
						{
							return oS;
						}
						set	
						{
							oS = value;
						}
					}

					public string Province
					{
						get
						{
							return province;
						}
						set	
						{
							province = value;
						}
					}
				}
			}

			public class DescribeRtcQualityMetric_PubInfo
			{

				private List<DescribeRtcQualityMetric_DataItem4> data2;

				private List<DescribeRtcQualityMetric_EventsItem9> events3;

				private DescribeRtcQualityMetric_User1 user1;

				public List<DescribeRtcQualityMetric_DataItem4> Data2
				{
					get
					{
						return data2;
					}
					set	
					{
						data2 = value;
					}
				}

				public List<DescribeRtcQualityMetric_EventsItem9> Events3
				{
					get
					{
						return events3;
					}
					set	
					{
						events3 = value;
					}
				}

				public DescribeRtcQualityMetric_User1 User1
				{
					get
					{
						return user1;
					}
					set	
					{
						user1 = value;
					}
				}

				public class DescribeRtcQualityMetric_DataItem4
				{

					private string time;

					private DescribeRtcQualityMetric_Fps5 fps5;

					private DescribeRtcQualityMetric_Resolution6 resolution6;

					private DescribeRtcQualityMetric_BitRate7 bitRate7;

					private DescribeRtcQualityMetric_Network8 network8;

					public string Time
					{
						get
						{
							return time;
						}
						set	
						{
							time = value;
						}
					}

					public DescribeRtcQualityMetric_Fps5 Fps5
					{
						get
						{
							return fps5;
						}
						set	
						{
							fps5 = value;
						}
					}

					public DescribeRtcQualityMetric_Resolution6 Resolution6
					{
						get
						{
							return resolution6;
						}
						set	
						{
							resolution6 = value;
						}
					}

					public DescribeRtcQualityMetric_BitRate7 BitRate7
					{
						get
						{
							return bitRate7;
						}
						set	
						{
							bitRate7 = value;
						}
					}

					public DescribeRtcQualityMetric_Network8 Network8
					{
						get
						{
							return network8;
						}
						set	
						{
							network8 = value;
						}
					}

					public class DescribeRtcQualityMetric_Fps5
					{

						private long? small;

						private long? large;

						private long? super;

						private long? share;

						public long? Small
						{
							get
							{
								return small;
							}
							set	
							{
								small = value;
							}
						}

						public long? Large
						{
							get
							{
								return large;
							}
							set	
							{
								large = value;
							}
						}

						public long? Super
						{
							get
							{
								return super;
							}
							set	
							{
								super = value;
							}
						}

						public long? Share
						{
							get
							{
								return share;
							}
							set	
							{
								share = value;
							}
						}
					}

					public class DescribeRtcQualityMetric_Resolution6
					{

						private long? small;

						private long? large;

						private long? super;

						private long? share;

						public long? Small
						{
							get
							{
								return small;
							}
							set	
							{
								small = value;
							}
						}

						public long? Large
						{
							get
							{
								return large;
							}
							set	
							{
								large = value;
							}
						}

						public long? Super
						{
							get
							{
								return super;
							}
							set	
							{
								super = value;
							}
						}

						public long? Share
						{
							get
							{
								return share;
							}
							set	
							{
								share = value;
							}
						}
					}

					public class DescribeRtcQualityMetric_BitRate7
					{

						private long? audio;

						private long? small;

						private long? large;

						private long? super;

						private long? share;

						public long? Audio
						{
							get
							{
								return audio;
							}
							set	
							{
								audio = value;
							}
						}

						public long? Small
						{
							get
							{
								return small;
							}
							set	
							{
								small = value;
							}
						}

						public long? Large
						{
							get
							{
								return large;
							}
							set	
							{
								large = value;
							}
						}

						public long? Super
						{
							get
							{
								return super;
							}
							set	
							{
								super = value;
							}
						}

						public long? Share
						{
							get
							{
								return share;
							}
							set	
							{
								share = value;
							}
						}
					}

					public class DescribeRtcQualityMetric_Network8
					{

						private float? loss;

						private long? rtt;

						public float? Loss
						{
							get
							{
								return loss;
							}
							set	
							{
								loss = value;
							}
						}

						public long? Rtt
						{
							get
							{
								return rtt;
							}
							set	
							{
								rtt = value;
							}
						}
					}
				}

				public class DescribeRtcQualityMetric_EventsItem9
				{

					private string time;

					private long? eventId;

					private string name;

					private string category;

					private string result;

					private string description;

					public string Time
					{
						get
						{
							return time;
						}
						set	
						{
							time = value;
						}
					}

					public long? EventId
					{
						get
						{
							return eventId;
						}
						set	
						{
							eventId = value;
						}
					}

					public string Name
					{
						get
						{
							return name;
						}
						set	
						{
							name = value;
						}
					}

					public string Category
					{
						get
						{
							return category;
						}
						set	
						{
							category = value;
						}
					}

					public string Result
					{
						get
						{
							return result;
						}
						set	
						{
							result = value;
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
				}

				public class DescribeRtcQualityMetric_User1
				{

					private string userId;

					private string sDKVersion;

					private string oS;

					private string province;

					public string UserId
					{
						get
						{
							return userId;
						}
						set	
						{
							userId = value;
						}
					}

					public string SDKVersion
					{
						get
						{
							return sDKVersion;
						}
						set	
						{
							sDKVersion = value;
						}
					}

					public string OS
					{
						get
						{
							return oS;
						}
						set	
						{
							oS = value;
						}
					}

					public string Province
					{
						get
						{
							return province;
						}
						set	
						{
							province = value;
						}
					}
				}
			}
		}
	}
}
