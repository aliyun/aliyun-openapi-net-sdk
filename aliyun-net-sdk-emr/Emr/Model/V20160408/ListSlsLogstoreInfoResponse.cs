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

namespace Aliyun.Acs.Emr.Model.V20160408
{
	public class ListSlsLogstoreInfoResponse : AcsResponse
	{

		private string requestId;

		private List<ListSlsLogstoreInfo_SlsLogstoreInfo> slsLogstoreInfoList;

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

		public List<ListSlsLogstoreInfo_SlsLogstoreInfo> SlsLogstoreInfoList
		{
			get
			{
				return slsLogstoreInfoList;
			}
			set	
			{
				slsLogstoreInfoList = value;
			}
		}

		public class ListSlsLogstoreInfo_SlsLogstoreInfo
		{

			private long? id;

			private string serviceName;

			private string componentName;

			private string logstoreName;

			private string logType;

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

			public string ServiceName
			{
				get
				{
					return serviceName;
				}
				set	
				{
					serviceName = value;
				}
			}

			public string ComponentName
			{
				get
				{
					return componentName;
				}
				set	
				{
					componentName = value;
				}
			}

			public string LogstoreName
			{
				get
				{
					return logstoreName;
				}
				set	
				{
					logstoreName = value;
				}
			}

			public string LogType
			{
				get
				{
					return logType;
				}
				set	
				{
					logType = value;
				}
			}
		}
	}
}
