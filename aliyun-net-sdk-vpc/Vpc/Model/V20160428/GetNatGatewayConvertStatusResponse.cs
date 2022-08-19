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
	public class GetNatGatewayConvertStatusResponse : AcsResponse
	{

		private long? aliUid;

		private string requestId;

		private string dstNatType;

		private string bid;

		private string natGatewayId;

		private List<GetNatGatewayConvertStatus_ConvertStep> convertSteps;

		public long? AliUid
		{
			get
			{
				return aliUid;
			}
			set	
			{
				aliUid = value;
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

		public string DstNatType
		{
			get
			{
				return dstNatType;
			}
			set	
			{
				dstNatType = value;
			}
		}

		public string Bid
		{
			get
			{
				return bid;
			}
			set	
			{
				bid = value;
			}
		}

		public string NatGatewayId
		{
			get
			{
				return natGatewayId;
			}
			set	
			{
				natGatewayId = value;
			}
		}

		public List<GetNatGatewayConvertStatus_ConvertStep> ConvertSteps
		{
			get
			{
				return convertSteps;
			}
			set	
			{
				convertSteps = value;
			}
		}

		public class GetNatGatewayConvertStatus_ConvertStep
		{

			private string stepStartTime;

			private string stepName;

			private string stepStatus;

			public string StepStartTime
			{
				get
				{
					return stepStartTime;
				}
				set	
				{
					stepStartTime = value;
				}
			}

			public string StepName
			{
				get
				{
					return stepName;
				}
				set	
				{
					stepName = value;
				}
			}

			public string StepStatus
			{
				get
				{
					return stepStatus;
				}
				set	
				{
					stepStatus = value;
				}
			}
		}
	}
}
