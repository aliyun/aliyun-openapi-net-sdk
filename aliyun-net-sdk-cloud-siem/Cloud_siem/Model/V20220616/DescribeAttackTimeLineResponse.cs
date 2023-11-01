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

namespace Aliyun.Acs.cloud_siem.Model.V20220616
{
	public class DescribeAttackTimeLineResponse : AcsResponse
	{

		private bool? success;

		private int? code;

		private string message;

		private string requestId;

		private List<DescribeAttackTimeLine_DataItem> data;

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

		public int? Code
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

		public string Message
		{
			get
			{
				return message;
			}
			set	
			{
				message = value;
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

		public List<DescribeAttackTimeLine_DataItem> Data
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

		public class DescribeAttackTimeLine_DataItem
		{

			private string assetName;

			private long? alertTime;

			private string assetId;

			private string incidentUuid;

			private string alertUuid;

			private string logTime;

			private string alertSrcProd;

			private string alertTitle;

			private string alertLevel;

			private string assetList;

			private string alertSrcProdModule;

			private string attCk;

			private string cloudCode;

			private string alertTitleEn;

			private string alertType;

			private string alertTypeEn;

			private string alertTypeCode;

			private string alertName;

			private string alertNameEn;

			private string alertNameCode;

			public string AssetName
			{
				get
				{
					return assetName;
				}
				set	
				{
					assetName = value;
				}
			}

			public long? AlertTime
			{
				get
				{
					return alertTime;
				}
				set	
				{
					alertTime = value;
				}
			}

			public string AssetId
			{
				get
				{
					return assetId;
				}
				set	
				{
					assetId = value;
				}
			}

			public string IncidentUuid
			{
				get
				{
					return incidentUuid;
				}
				set	
				{
					incidentUuid = value;
				}
			}

			public string AlertUuid
			{
				get
				{
					return alertUuid;
				}
				set	
				{
					alertUuid = value;
				}
			}

			public string LogTime
			{
				get
				{
					return logTime;
				}
				set	
				{
					logTime = value;
				}
			}

			public string AlertSrcProd
			{
				get
				{
					return alertSrcProd;
				}
				set	
				{
					alertSrcProd = value;
				}
			}

			public string AlertTitle
			{
				get
				{
					return alertTitle;
				}
				set	
				{
					alertTitle = value;
				}
			}

			public string AlertLevel
			{
				get
				{
					return alertLevel;
				}
				set	
				{
					alertLevel = value;
				}
			}

			public string AssetList
			{
				get
				{
					return assetList;
				}
				set	
				{
					assetList = value;
				}
			}

			public string AlertSrcProdModule
			{
				get
				{
					return alertSrcProdModule;
				}
				set	
				{
					alertSrcProdModule = value;
				}
			}

			public string AttCk
			{
				get
				{
					return attCk;
				}
				set	
				{
					attCk = value;
				}
			}

			public string CloudCode
			{
				get
				{
					return cloudCode;
				}
				set	
				{
					cloudCode = value;
				}
			}

			public string AlertTitleEn
			{
				get
				{
					return alertTitleEn;
				}
				set	
				{
					alertTitleEn = value;
				}
			}

			public string AlertType
			{
				get
				{
					return alertType;
				}
				set	
				{
					alertType = value;
				}
			}

			public string AlertTypeEn
			{
				get
				{
					return alertTypeEn;
				}
				set	
				{
					alertTypeEn = value;
				}
			}

			public string AlertTypeCode
			{
				get
				{
					return alertTypeCode;
				}
				set	
				{
					alertTypeCode = value;
				}
			}

			public string AlertName
			{
				get
				{
					return alertName;
				}
				set	
				{
					alertName = value;
				}
			}

			public string AlertNameEn
			{
				get
				{
					return alertNameEn;
				}
				set	
				{
					alertNameEn = value;
				}
			}

			public string AlertNameCode
			{
				get
				{
					return alertNameCode;
				}
				set	
				{
					alertNameCode = value;
				}
			}
		}
	}
}
