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
using Newtonsoft.Json;
using Aliyun.Acs.Core;

namespace Aliyun.Acs.dms_enterprise.Model.V20181101
{
	public class ListLogicTableRouteConfigResponse : AcsResponse
	{

		private string requestId;

		private string errorCode;

		private string errorMessage;

		private bool? success;

		private List<ListLogicTableRouteConfig_LogicTableRouteConfig> logicTableRouteConfigList;

		[JsonProperty(PropertyName = "RequestId")]
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

		[JsonProperty(PropertyName = "ErrorCode")]
		public string ErrorCode
		{
			get
			{
				return errorCode;
			}
			set	
			{
				errorCode = value;
			}
		}

		[JsonProperty(PropertyName = "ErrorMessage")]
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

		[JsonProperty(PropertyName = "Success")]
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

		[JsonProperty(PropertyName = "LogicTableRouteConfigList")]
		public List<ListLogicTableRouteConfig_LogicTableRouteConfig> LogicTableRouteConfigList
		{
			get
			{
				return logicTableRouteConfigList;
			}
			set	
			{
				logicTableRouteConfigList = value;
			}
		}

		public class ListLogicTableRouteConfig_LogicTableRouteConfig
		{

			private string routeKey;

			private string routeExpr;

			private long? tableId;

			[JsonProperty(PropertyName = "RouteKey")]
			public string RouteKey
			{
				get
				{
					return routeKey;
				}
				set	
				{
					routeKey = value;
				}
			}

			[JsonProperty(PropertyName = "RouteExpr")]
			public string RouteExpr
			{
				get
				{
					return routeExpr;
				}
				set	
				{
					routeExpr = value;
				}
			}

			[JsonProperty(PropertyName = "TableId")]
			public long? TableId
			{
				get
				{
					return tableId;
				}
				set	
				{
					tableId = value;
				}
			}
		}
	}
}
