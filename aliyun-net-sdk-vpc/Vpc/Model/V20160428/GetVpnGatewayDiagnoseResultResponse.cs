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

namespace Aliyun.Acs.Vpc.Model.V20160428
{
	public class GetVpnGatewayDiagnoseResultResponse : AcsResponse
	{

		private string beginTime;

		private string diagnoseId;

		private string finishTime;

		private int? finishedCount;

		private string requestId;

		private string resourceInstanceId;

		private string resourceType;

		private int? totalCount;

		private string vpnGatewayId;

		private List<GetVpnGatewayDiagnoseResult_DiagnoseResultItem> diagnoseResult;

		public string BeginTime
		{
			get
			{
				return beginTime;
			}
			set	
			{
				beginTime = value;
			}
		}

		public string DiagnoseId
		{
			get
			{
				return diagnoseId;
			}
			set	
			{
				diagnoseId = value;
			}
		}

		public string FinishTime
		{
			get
			{
				return finishTime;
			}
			set	
			{
				finishTime = value;
			}
		}

		public int? FinishedCount
		{
			get
			{
				return finishedCount;
			}
			set	
			{
				finishedCount = value;
			}
		}

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

		public string ResourceInstanceId
		{
			get
			{
				return resourceInstanceId;
			}
			set	
			{
				resourceInstanceId = value;
			}
		}

		public string ResourceType
		{
			get
			{
				return resourceType;
			}
			set	
			{
				resourceType = value;
			}
		}

		public int? TotalCount
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

		public string VpnGatewayId
		{
			get
			{
				return vpnGatewayId;
			}
			set	
			{
				vpnGatewayId = value;
			}
		}

		public List<GetVpnGatewayDiagnoseResult_DiagnoseResultItem> DiagnoseResult
		{
			get
			{
				return diagnoseResult;
			}
			set	
			{
				diagnoseResult = value;
			}
		}

		public class GetVpnGatewayDiagnoseResult_DiagnoseResultItem
		{

			private string diagnoseName;

			private string diagnoseResultDescription;

			private string diagnoseResultLevel;

			public string DiagnoseName
			{
				get
				{
					return diagnoseName;
				}
				set	
				{
					diagnoseName = value;
				}
			}

			public string DiagnoseResultDescription
			{
				get
				{
					return diagnoseResultDescription;
				}
				set	
				{
					diagnoseResultDescription = value;
				}
			}

			public string DiagnoseResultLevel
			{
				get
				{
					return diagnoseResultLevel;
				}
				set	
				{
					diagnoseResultLevel = value;
				}
			}
		}
	}
}
