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

namespace Aliyun.Acs.sophonsoar.Model.V20220728
{
	public class VerifyPlaybookResponse : AcsResponse
	{

		private string requestId;

		private List<VerifyPlaybook_CheckTaskInfosItem> checkTaskInfos;

		private List<VerifyPlaybook_PrerequisitesItem> prerequisites;

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

		public List<VerifyPlaybook_CheckTaskInfosItem> CheckTaskInfos
		{
			get
			{
				return checkTaskInfos;
			}
			set	
			{
				checkTaskInfos = value;
			}
		}

		public List<VerifyPlaybook_PrerequisitesItem> Prerequisites
		{
			get
			{
				return prerequisites;
			}
			set	
			{
				prerequisites = value;
			}
		}

		public class VerifyPlaybook_CheckTaskInfosItem
		{

			private string riskLevel;

			private string nodeName;

			private string detail;

			public string RiskLevel
			{
				get
				{
					return riskLevel;
				}
				set	
				{
					riskLevel = value;
				}
			}

			public string NodeName
			{
				get
				{
					return nodeName;
				}
				set	
				{
					nodeName = value;
				}
			}

			public string Detail
			{
				get
				{
					return detail;
				}
				set	
				{
					detail = value;
				}
			}
		}

		public class VerifyPlaybook_PrerequisitesItem
		{

			private string prerequisiteType;

			private string prerequisiteValue;

			public string PrerequisiteType
			{
				get
				{
					return prerequisiteType;
				}
				set	
				{
					prerequisiteType = value;
				}
			}

			public string PrerequisiteValue
			{
				get
				{
					return prerequisiteValue;
				}
				set	
				{
					prerequisiteValue = value;
				}
			}
		}
	}
}
