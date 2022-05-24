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

namespace Aliyun.Acs.Rds.Model.V20140815
{
	public class DescribeRdsResourceSettingsResponse : AcsResponse
	{

		private string requestId;

		private List<DescribeRdsResourceSettings_RdsInstanceResourceSetting> rdsInstanceResourceSettings;

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

		[JsonProperty(PropertyName = "RdsInstanceResourceSettings")]
		public List<DescribeRdsResourceSettings_RdsInstanceResourceSetting> RdsInstanceResourceSettings
		{
			get
			{
				return rdsInstanceResourceSettings;
			}
			set	
			{
				rdsInstanceResourceSettings = value;
			}
		}

		public class DescribeRdsResourceSettings_RdsInstanceResourceSetting
		{

			private string poppedUpButtonType;

			private string noticeBarContent;

			private string endDate;

			private string poppedUpContent;

			private string startDate;

			private string poppedUpButtonText;

			private string isTop;

			private string resourceNiche;

			private string poppedUpButtonUrl;

			[JsonProperty(PropertyName = "PoppedUpButtonType")]
			public string PoppedUpButtonType
			{
				get
				{
					return poppedUpButtonType;
				}
				set	
				{
					poppedUpButtonType = value;
				}
			}

			[JsonProperty(PropertyName = "NoticeBarContent")]
			public string NoticeBarContent
			{
				get
				{
					return noticeBarContent;
				}
				set	
				{
					noticeBarContent = value;
				}
			}

			[JsonProperty(PropertyName = "EndDate")]
			public string EndDate
			{
				get
				{
					return endDate;
				}
				set	
				{
					endDate = value;
				}
			}

			[JsonProperty(PropertyName = "PoppedUpContent")]
			public string PoppedUpContent
			{
				get
				{
					return poppedUpContent;
				}
				set	
				{
					poppedUpContent = value;
				}
			}

			[JsonProperty(PropertyName = "StartDate")]
			public string StartDate
			{
				get
				{
					return startDate;
				}
				set	
				{
					startDate = value;
				}
			}

			[JsonProperty(PropertyName = "PoppedUpButtonText")]
			public string PoppedUpButtonText
			{
				get
				{
					return poppedUpButtonText;
				}
				set	
				{
					poppedUpButtonText = value;
				}
			}

			[JsonProperty(PropertyName = "IsTop")]
			public string IsTop
			{
				get
				{
					return isTop;
				}
				set	
				{
					isTop = value;
				}
			}

			[JsonProperty(PropertyName = "ResourceNiche")]
			public string ResourceNiche
			{
				get
				{
					return resourceNiche;
				}
				set	
				{
					resourceNiche = value;
				}
			}

			[JsonProperty(PropertyName = "PoppedUpButtonUrl")]
			public string PoppedUpButtonUrl
			{
				get
				{
					return poppedUpButtonUrl;
				}
				set	
				{
					poppedUpButtonUrl = value;
				}
			}
		}
	}
}
