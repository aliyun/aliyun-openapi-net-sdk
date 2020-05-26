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

namespace Aliyun.Acs.Sas.Model.V20181203
{
	public class DescribeSuspEventDetailResponse : AcsResponse
	{

		private string requestId;

		private string lastTime;

		private int? id;

		private string instanceName;

		private string internetIp;

		private string intranetIp;

		private string uuid;

		private string eventDesc;

		private string eventTypeDesc;

		private string level;

		private string eventStatus;

		private string saleVersion;

		private string dataSource;

		private string type;

		private string operateMsg;

		private string sasId;

		private string eventName;

		private bool? canBeDealOnLine;

		private string operateErrorCode;

		private List<DescribeSuspEventDetail_QuaraFile> details;

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

		public string LastTime
		{
			get
			{
				return lastTime;
			}
			set	
			{
				lastTime = value;
			}
		}

		public int? Id
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

		public string InstanceName
		{
			get
			{
				return instanceName;
			}
			set	
			{
				instanceName = value;
			}
		}

		public string InternetIp
		{
			get
			{
				return internetIp;
			}
			set	
			{
				internetIp = value;
			}
		}

		public string IntranetIp
		{
			get
			{
				return intranetIp;
			}
			set	
			{
				intranetIp = value;
			}
		}

		public string Uuid
		{
			get
			{
				return uuid;
			}
			set	
			{
				uuid = value;
			}
		}

		public string EventDesc
		{
			get
			{
				return eventDesc;
			}
			set	
			{
				eventDesc = value;
			}
		}

		public string EventTypeDesc
		{
			get
			{
				return eventTypeDesc;
			}
			set	
			{
				eventTypeDesc = value;
			}
		}

		public string Level
		{
			get
			{
				return level;
			}
			set	
			{
				level = value;
			}
		}

		public string EventStatus
		{
			get
			{
				return eventStatus;
			}
			set	
			{
				eventStatus = value;
			}
		}

		public string SaleVersion
		{
			get
			{
				return saleVersion;
			}
			set	
			{
				saleVersion = value;
			}
		}

		public string DataSource
		{
			get
			{
				return dataSource;
			}
			set	
			{
				dataSource = value;
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

		public string OperateMsg
		{
			get
			{
				return operateMsg;
			}
			set	
			{
				operateMsg = value;
			}
		}

		public string SasId
		{
			get
			{
				return sasId;
			}
			set	
			{
				sasId = value;
			}
		}

		public string EventName
		{
			get
			{
				return eventName;
			}
			set	
			{
				eventName = value;
			}
		}

		public bool? CanBeDealOnLine
		{
			get
			{
				return canBeDealOnLine;
			}
			set	
			{
				canBeDealOnLine = value;
			}
		}

		public string OperateErrorCode
		{
			get
			{
				return operateErrorCode;
			}
			set	
			{
				operateErrorCode = value;
			}
		}

		public List<DescribeSuspEventDetail_QuaraFile> Details
		{
			get
			{
				return details;
			}
			set	
			{
				details = value;
			}
		}

		public class DescribeSuspEventDetail_QuaraFile
		{

			private string name;

			private string type;

			private string infoType;

			private string _value;

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

			public string InfoType
			{
				get
				{
					return infoType;
				}
				set	
				{
					infoType = value;
				}
			}

			public string _Value
			{
				get
				{
					return _value;
				}
				set	
				{
					_value = value;
				}
			}
		}
	}
}
