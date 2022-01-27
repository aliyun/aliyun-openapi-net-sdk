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

namespace Aliyun.Acs.Iot.Model.V20180120
{
	public class GetEdgeInstanceMessageRoutingResponse : AcsResponse
	{

		private string requestId;

		private bool? success;

		private string code;

		private string errorMessage;

		private GetEdgeInstanceMessageRouting_Data data;

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

		public string ErrorMessage
		{
			get
			{
				return errorMessage;
			}
			set	
			{
				errorMessage = value;
			}
		}

		public GetEdgeInstanceMessageRouting_Data Data
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

		public class GetEdgeInstanceMessageRouting_Data
		{

			private string topicFilter;

			private string sourceType;

			private string name;

			private string sourceData;

			private string targetType;

			private string targetData;

			private string gmtCreate;

			private string gmtModified;

			private long? gmtCreateTimestamp;

			private long? gmtModifiedTimestamp;

			private GetEdgeInstanceMessageRouting_RouteContext routeContext;

			public string TopicFilter
			{
				get
				{
					return topicFilter;
				}
				set	
				{
					topicFilter = value;
				}
			}

			public string SourceType
			{
				get
				{
					return sourceType;
				}
				set	
				{
					sourceType = value;
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

			public string SourceData
			{
				get
				{
					return sourceData;
				}
				set	
				{
					sourceData = value;
				}
			}

			public string TargetType
			{
				get
				{
					return targetType;
				}
				set	
				{
					targetType = value;
				}
			}

			public string TargetData
			{
				get
				{
					return targetData;
				}
				set	
				{
					targetData = value;
				}
			}

			public string GmtCreate
			{
				get
				{
					return gmtCreate;
				}
				set	
				{
					gmtCreate = value;
				}
			}

			public string GmtModified
			{
				get
				{
					return gmtModified;
				}
				set	
				{
					gmtModified = value;
				}
			}

			public long? GmtCreateTimestamp
			{
				get
				{
					return gmtCreateTimestamp;
				}
				set	
				{
					gmtCreateTimestamp = value;
				}
			}

			public long? GmtModifiedTimestamp
			{
				get
				{
					return gmtModifiedTimestamp;
				}
				set	
				{
					gmtModifiedTimestamp = value;
				}
			}

			public GetEdgeInstanceMessageRouting_RouteContext RouteContext
			{
				get
				{
					return routeContext;
				}
				set	
				{
					routeContext = value;
				}
			}

			public class GetEdgeInstanceMessageRouting_RouteContext
			{

				private string sourceFcServiceName;

				private string sourceFcFunctionName;

				private string sourceStreamName;

				private string sourceApplicationName;

				private string targetFcServiceName;

				private string targetFcFunctionName;

				private string targetStreamName;

				private string targetApplicationName;

				private string qos;

				public string SourceFcServiceName
				{
					get
					{
						return sourceFcServiceName;
					}
					set	
					{
						sourceFcServiceName = value;
					}
				}

				public string SourceFcFunctionName
				{
					get
					{
						return sourceFcFunctionName;
					}
					set	
					{
						sourceFcFunctionName = value;
					}
				}

				public string SourceStreamName
				{
					get
					{
						return sourceStreamName;
					}
					set	
					{
						sourceStreamName = value;
					}
				}

				public string SourceApplicationName
				{
					get
					{
						return sourceApplicationName;
					}
					set	
					{
						sourceApplicationName = value;
					}
				}

				public string TargetFcServiceName
				{
					get
					{
						return targetFcServiceName;
					}
					set	
					{
						targetFcServiceName = value;
					}
				}

				public string TargetFcFunctionName
				{
					get
					{
						return targetFcFunctionName;
					}
					set	
					{
						targetFcFunctionName = value;
					}
				}

				public string TargetStreamName
				{
					get
					{
						return targetStreamName;
					}
					set	
					{
						targetStreamName = value;
					}
				}

				public string TargetApplicationName
				{
					get
					{
						return targetApplicationName;
					}
					set	
					{
						targetApplicationName = value;
					}
				}

				public string Qos
				{
					get
					{
						return qos;
					}
					set	
					{
						qos = value;
					}
				}
			}
		}
	}
}
