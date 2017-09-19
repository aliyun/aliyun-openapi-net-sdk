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
using Aliyun.Acs.Core;
using System.Collections.Generic;

namespace Aliyun.Acs.Ons.Model.V20170918
{
	public class OnsTraceGetResultResponse : AcsResponse
	{

		private string requestId;

		private string helpUrl;

		private OnsTraceGetResult_TraceData traceData;

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

		public OnsTraceGetResult_TraceData TraceData
		{
			get
			{
				return traceData;
			}
			set	
			{
				traceData = value;
			}
		}

		public class OnsTraceGetResult_TraceData
		{

			private string queryId;

			private string userId;

			private string topic;

			private string msgId;

			private string msgKey;

			private string status;

			private long? createTime;

			private long? updateTime;

			private List<OnsTraceGetResult_TraceMapDo> traceList;

			public string QueryId
			{
				get
				{
					return queryId;
				}
				set	
				{
					queryId = value;
				}
			}

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

			public string MsgId
			{
				get
				{
					return msgId;
				}
				set	
				{
					msgId = value;
				}
			}

			public string MsgKey
			{
				get
				{
					return msgKey;
				}
				set	
				{
					msgKey = value;
				}
			}

			public string Status
			{
				get
				{
					return status;
				}
				set	
				{
					status = value;
				}
			}

			public long? CreateTime
			{
				get
				{
					return createTime;
				}
				set	
				{
					createTime = value;
				}
			}

			public long? UpdateTime
			{
				get
				{
					return updateTime;
				}
				set	
				{
					updateTime = value;
				}
			}

			public List<OnsTraceGetResult_TraceMapDo> TraceList
			{
				get
				{
					return traceList;
				}
				set	
				{
					traceList = value;
				}
			}

			public class OnsTraceGetResult_TraceMapDo
			{

				private long? pubTime;

				private string topic;

				private string pubGroupName;

				private string msgId;

				private string tag;

				private string msgKey;

				private string bornHost;

				private int? costTime;

				private string status;

				private List<OnsTraceGetResult_SubMapDo> subList;

				public long? PubTime
				{
					get
					{
						return pubTime;
					}
					set	
					{
						pubTime = value;
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

				public string PubGroupName
				{
					get
					{
						return pubGroupName;
					}
					set	
					{
						pubGroupName = value;
					}
				}

				public string MsgId
				{
					get
					{
						return msgId;
					}
					set	
					{
						msgId = value;
					}
				}

				public string Tag
				{
					get
					{
						return tag;
					}
					set	
					{
						tag = value;
					}
				}

				public string MsgKey
				{
					get
					{
						return msgKey;
					}
					set	
					{
						msgKey = value;
					}
				}

				public string BornHost
				{
					get
					{
						return bornHost;
					}
					set	
					{
						bornHost = value;
					}
				}

				public int? CostTime
				{
					get
					{
						return costTime;
					}
					set	
					{
						costTime = value;
					}
				}

				public string Status
				{
					get
					{
						return status;
					}
					set	
					{
						status = value;
					}
				}

				public List<OnsTraceGetResult_SubMapDo> SubList
				{
					get
					{
						return subList;
					}
					set	
					{
						subList = value;
					}
				}

				public class OnsTraceGetResult_SubMapDo
				{

					private string subGroupName;

					private int? successCount;

					private int? failCount;

					private List<OnsTraceGetResult_SubClientInfoDo> clientList;

					public string SubGroupName
					{
						get
						{
							return subGroupName;
						}
						set	
						{
							subGroupName = value;
						}
					}

					public int? SuccessCount
					{
						get
						{
							return successCount;
						}
						set	
						{
							successCount = value;
						}
					}

					public int? FailCount
					{
						get
						{
							return failCount;
						}
						set	
						{
							failCount = value;
						}
					}

					public List<OnsTraceGetResult_SubClientInfoDo> ClientList
					{
						get
						{
							return clientList;
						}
						set	
						{
							clientList = value;
						}
					}

					public class OnsTraceGetResult_SubClientInfoDo
					{

						private string subGroupName;

						private long? subTime;

						private string clientHost;

						private int? reconsumeTimes;

						private int? costTime;

						private string status;

						public string SubGroupName
						{
							get
							{
								return subGroupName;
							}
							set	
							{
								subGroupName = value;
							}
						}

						public long? SubTime
						{
							get
							{
								return subTime;
							}
							set	
							{
								subTime = value;
							}
						}

						public string ClientHost
						{
							get
							{
								return clientHost;
							}
							set	
							{
								clientHost = value;
							}
						}

						public int? ReconsumeTimes
						{
							get
							{
								return reconsumeTimes;
							}
							set	
							{
								reconsumeTimes = value;
							}
						}

						public int? CostTime
						{
							get
							{
								return costTime;
							}
							set	
							{
								costTime = value;
							}
						}

						public string Status
						{
							get
							{
								return status;
							}
							set	
							{
								status = value;
							}
						}
					}
				}
			}
		}
	}
}