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

namespace Aliyun.Acs.UniMkt.Model.V20181212
{
	public class QuerySlotResponse : AcsResponse
	{

		private string code;

		private bool? success;

		private string message;

		private string requestId;

		private QuerySlot_Model model;

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

		public QuerySlot_Model Model
		{
			get
			{
				return model;
			}
			set	
			{
				model = value;
			}
		}

		public class QuerySlot_Model
		{

			private long? createTime;

			private long? modifyTime;

			private string tenantId;

			private string mediaName;

			private string mediaId;

			private string adSlotId;

			private string adSlotName;

			private string adSlotType;

			private string adSlotTemplateId;

			private string adSlotStatus;

			private string adSlotCorporateStatus;

			private string extInfo;

			private string blockingRule;

			private string inspireScene;

			private long? version;

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

			public long? ModifyTime
			{
				get
				{
					return modifyTime;
				}
				set	
				{
					modifyTime = value;
				}
			}

			public string TenantId
			{
				get
				{
					return tenantId;
				}
				set	
				{
					tenantId = value;
				}
			}

			public string MediaName
			{
				get
				{
					return mediaName;
				}
				set	
				{
					mediaName = value;
				}
			}

			public string MediaId
			{
				get
				{
					return mediaId;
				}
				set	
				{
					mediaId = value;
				}
			}

			public string AdSlotId
			{
				get
				{
					return adSlotId;
				}
				set	
				{
					adSlotId = value;
				}
			}

			public string AdSlotName
			{
				get
				{
					return adSlotName;
				}
				set	
				{
					adSlotName = value;
				}
			}

			public string AdSlotType
			{
				get
				{
					return adSlotType;
				}
				set	
				{
					adSlotType = value;
				}
			}

			public string AdSlotTemplateId
			{
				get
				{
					return adSlotTemplateId;
				}
				set	
				{
					adSlotTemplateId = value;
				}
			}

			public string AdSlotStatus
			{
				get
				{
					return adSlotStatus;
				}
				set	
				{
					adSlotStatus = value;
				}
			}

			public string AdSlotCorporateStatus
			{
				get
				{
					return adSlotCorporateStatus;
				}
				set	
				{
					adSlotCorporateStatus = value;
				}
			}

			public string ExtInfo
			{
				get
				{
					return extInfo;
				}
				set	
				{
					extInfo = value;
				}
			}

			public string BlockingRule
			{
				get
				{
					return blockingRule;
				}
				set	
				{
					blockingRule = value;
				}
			}

			public string InspireScene
			{
				get
				{
					return inspireScene;
				}
				set	
				{
					inspireScene = value;
				}
			}

			public long? Version
			{
				get
				{
					return version;
				}
				set	
				{
					version = value;
				}
			}
		}
	}
}
