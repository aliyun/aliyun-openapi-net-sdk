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

namespace Aliyun.Acs.Ons.Model.V20190214
{
	public class OnsConsumerStatusResponse : AcsResponse
	{

		private string requestId;

		private string helpUrl;

		private OnsConsumerStatus_Data data;

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

		public string HelpUrl
		{
			get
			{
				return helpUrl;
			}
			set	
			{
				helpUrl = value;
			}
		}

		public OnsConsumerStatus_Data Data
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

		public class OnsConsumerStatus_Data
		{

			private float? consumeTps;

			private string consumeModel;

			private long? totalDiff;

			private string instanceId;

			private bool? subscriptionSame;

			private long? delayTime;

			private long? lastTimestamp;

			private bool? online;

			private bool? rebalanceOK;

			private List<OnsConsumerStatus_ConnectionDo> connectionSet;

			private List<OnsConsumerStatus_ConsumerConnectionInfoDo> consumerConnectionInfoList;

			private List<OnsConsumerStatus_DetailInTopicDo> detailInTopicList;

			public float? ConsumeTps
			{
				get
				{
					return consumeTps;
				}
				set	
				{
					consumeTps = value;
				}
			}

			public string ConsumeModel
			{
				get
				{
					return consumeModel;
				}
				set	
				{
					consumeModel = value;
				}
			}

			public long? TotalDiff
			{
				get
				{
					return totalDiff;
				}
				set	
				{
					totalDiff = value;
				}
			}

			public string InstanceId
			{
				get
				{
					return instanceId;
				}
				set	
				{
					instanceId = value;
				}
			}

			public bool? SubscriptionSame
			{
				get
				{
					return subscriptionSame;
				}
				set	
				{
					subscriptionSame = value;
				}
			}

			public long? DelayTime
			{
				get
				{
					return delayTime;
				}
				set	
				{
					delayTime = value;
				}
			}

			public long? LastTimestamp
			{
				get
				{
					return lastTimestamp;
				}
				set	
				{
					lastTimestamp = value;
				}
			}

			public bool? Online
			{
				get
				{
					return online;
				}
				set	
				{
					online = value;
				}
			}

			public bool? RebalanceOK
			{
				get
				{
					return rebalanceOK;
				}
				set	
				{
					rebalanceOK = value;
				}
			}

			public List<OnsConsumerStatus_ConnectionDo> ConnectionSet
			{
				get
				{
					return connectionSet;
				}
				set	
				{
					connectionSet = value;
				}
			}

			public List<OnsConsumerStatus_ConsumerConnectionInfoDo> ConsumerConnectionInfoList
			{
				get
				{
					return consumerConnectionInfoList;
				}
				set	
				{
					consumerConnectionInfoList = value;
				}
			}

			public List<OnsConsumerStatus_DetailInTopicDo> DetailInTopicList
			{
				get
				{
					return detailInTopicList;
				}
				set	
				{
					detailInTopicList = value;
				}
			}

			public class OnsConsumerStatus_ConnectionDo
			{

				private string remoteIP;

				private string version;

				private string clientAddr;

				private string language;

				private string clientId;

				public string RemoteIP
				{
					get
					{
						return remoteIP;
					}
					set	
					{
						remoteIP = value;
					}
				}

				public string Version
				{
					get
					{
						return version;
					}
					set	
					{
						version = value;
					}
				}

				public string ClientAddr
				{
					get
					{
						return clientAddr;
					}
					set	
					{
						clientAddr = value;
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

				public string ClientId
				{
					get
					{
						return clientId;
					}
					set	
					{
						clientId = value;
					}
				}
			}

			public class OnsConsumerStatus_ConsumerConnectionInfoDo
			{

				private string consumeModel;

				private long? lastTimeStamp;

				private long? startTimeStamp;

				private string language;

				private string clientId;

				private string connection;

				private string version;

				private string consumeType;

				private int? threadCount;

				private List<OnsConsumerStatus_ConsumerRunningDataDo> runningDataList;

				private List<OnsConsumerStatus_SubscriptionData> subscriptionSet;

				private List<OnsConsumerStatus_ThreadTrackDo> jstack;

				public string ConsumeModel
				{
					get
					{
						return consumeModel;
					}
					set	
					{
						consumeModel = value;
					}
				}

				public long? LastTimeStamp
				{
					get
					{
						return lastTimeStamp;
					}
					set	
					{
						lastTimeStamp = value;
					}
				}

				public long? StartTimeStamp
				{
					get
					{
						return startTimeStamp;
					}
					set	
					{
						startTimeStamp = value;
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

				public string ClientId
				{
					get
					{
						return clientId;
					}
					set	
					{
						clientId = value;
					}
				}

				public string Connection
				{
					get
					{
						return connection;
					}
					set	
					{
						connection = value;
					}
				}

				public string Version
				{
					get
					{
						return version;
					}
					set	
					{
						version = value;
					}
				}

				public string ConsumeType
				{
					get
					{
						return consumeType;
					}
					set	
					{
						consumeType = value;
					}
				}

				public int? ThreadCount
				{
					get
					{
						return threadCount;
					}
					set	
					{
						threadCount = value;
					}
				}

				public List<OnsConsumerStatus_ConsumerRunningDataDo> RunningDataList
				{
					get
					{
						return runningDataList;
					}
					set	
					{
						runningDataList = value;
					}
				}

				public List<OnsConsumerStatus_SubscriptionData> SubscriptionSet
				{
					get
					{
						return subscriptionSet;
					}
					set	
					{
						subscriptionSet = value;
					}
				}

				public List<OnsConsumerStatus_ThreadTrackDo> Jstack
				{
					get
					{
						return jstack;
					}
					set	
					{
						jstack = value;
					}
				}

				public class OnsConsumerStatus_ConsumerRunningDataDo
				{

					private string groupId;

					private float? rt;

					private string topic;

					private long? failedCountPerHour;

					private float? okTps;

					private float? failedTps;

					public string GroupId
					{
						get
						{
							return groupId;
						}
						set	
						{
							groupId = value;
						}
					}

					public float? Rt
					{
						get
						{
							return rt;
						}
						set	
						{
							rt = value;
						}
					}

					public string Topic
					{
						get
						{
							return topic;
						}
						set	
						{
							topic = value;
						}
					}

					public long? FailedCountPerHour
					{
						get
						{
							return failedCountPerHour;
						}
						set	
						{
							failedCountPerHour = value;
						}
					}

					public float? OkTps
					{
						get
						{
							return okTps;
						}
						set	
						{
							okTps = value;
						}
					}

					public float? FailedTps
					{
						get
						{
							return failedTps;
						}
						set	
						{
							failedTps = value;
						}
					}
				}

				public class OnsConsumerStatus_SubscriptionData
				{

					private string subString;

					private long? subVersion;

					private string topic;

					private List<string> tagsSet;

					public string SubString
					{
						get
						{
							return subString;
						}
						set	
						{
							subString = value;
						}
					}

					public long? SubVersion
					{
						get
						{
							return subVersion;
						}
						set	
						{
							subVersion = value;
						}
					}

					public string Topic
					{
						get
						{
							return topic;
						}
						set	
						{
							topic = value;
						}
					}

					public List<string> TagsSet
					{
						get
						{
							return tagsSet;
						}
						set	
						{
							tagsSet = value;
						}
					}
				}

				public class OnsConsumerStatus_ThreadTrackDo
				{

					private string thread;

					private List<string> trackList;

					public string Thread
					{
						get
						{
							return thread;
						}
						set	
						{
							thread = value;
						}
					}

					public List<string> TrackList
					{
						get
						{
							return trackList;
						}
						set	
						{
							trackList = value;
						}
					}
				}
			}

			public class OnsConsumerStatus_DetailInTopicDo
			{

				private long? delayTime;

				private long? totalDiff;

				private long? lastTimestamp;

				private string topic;

				public long? DelayTime
				{
					get
					{
						return delayTime;
					}
					set	
					{
						delayTime = value;
					}
				}

				public long? TotalDiff
				{
					get
					{
						return totalDiff;
					}
					set	
					{
						totalDiff = value;
					}
				}

				public long? LastTimestamp
				{
					get
					{
						return lastTimestamp;
					}
					set	
					{
						lastTimestamp = value;
					}
				}

				public string Topic
				{
					get
					{
						return topic;
					}
					set	
					{
						topic = value;
					}
				}
			}
		}
	}
}
