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
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.nis.Transform;
using Aliyun.Acs.nis.Transform.V20211216;

namespace Aliyun.Acs.nis.Model.V20211216
{
    public class GetVbrFlowTopNRequest : RpcAcsRequest<GetVbrFlowTopNResponse>
    {
        public GetVbrFlowTopNRequest()
            : base("nis", "2021-12-16", "GetVbrFlowTopN", "networkana", "openAPI")
        {
			Method = MethodType.POST;
        }

		private string otherPort;

		private int? topN;

		private string cloudPort;

		private string protocol;

		private string otherIp;

		private string orderBy;

		private string sort;

		private bool? useMultiAccount;

		private string cloudIp;

		private string cenId;

		private string virtualBorderRouterId;

		private string direction;

		private long? endTime;

		private long? beginTime;

		private string groupBy;

		private List<long?> accountIds = new List<long?>(){ };

		private string attachmentId;

		[JsonProperty(PropertyName = "OtherPort")]
		public string OtherPort
		{
			get
			{
				return otherPort;
			}
			set	
			{
				otherPort = value;
				DictionaryUtil.Add(QueryParameters, "OtherPort", value);
			}
		}

		[JsonProperty(PropertyName = "TopN")]
		public int? TopN
		{
			get
			{
				return topN;
			}
			set	
			{
				topN = value;
				DictionaryUtil.Add(QueryParameters, "TopN", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "CloudPort")]
		public string CloudPort
		{
			get
			{
				return cloudPort;
			}
			set	
			{
				cloudPort = value;
				DictionaryUtil.Add(QueryParameters, "CloudPort", value);
			}
		}

		[JsonProperty(PropertyName = "Protocol")]
		public string Protocol
		{
			get
			{
				return protocol;
			}
			set	
			{
				protocol = value;
				DictionaryUtil.Add(QueryParameters, "Protocol", value);
			}
		}

		[JsonProperty(PropertyName = "OtherIp")]
		public string OtherIp
		{
			get
			{
				return otherIp;
			}
			set	
			{
				otherIp = value;
				DictionaryUtil.Add(QueryParameters, "OtherIp", value);
			}
		}

		[JsonProperty(PropertyName = "OrderBy")]
		public string OrderBy
		{
			get
			{
				return orderBy;
			}
			set	
			{
				orderBy = value;
				DictionaryUtil.Add(QueryParameters, "OrderBy", value);
			}
		}

		[JsonProperty(PropertyName = "Sort")]
		public string Sort
		{
			get
			{
				return sort;
			}
			set	
			{
				sort = value;
				DictionaryUtil.Add(QueryParameters, "Sort", value);
			}
		}

		[JsonProperty(PropertyName = "UseMultiAccount")]
		public bool? UseMultiAccount
		{
			get
			{
				return useMultiAccount;
			}
			set	
			{
				useMultiAccount = value;
				DictionaryUtil.Add(QueryParameters, "UseMultiAccount", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "CloudIp")]
		public string CloudIp
		{
			get
			{
				return cloudIp;
			}
			set	
			{
				cloudIp = value;
				DictionaryUtil.Add(QueryParameters, "CloudIp", value);
			}
		}

		[JsonProperty(PropertyName = "CenId")]
		public string CenId
		{
			get
			{
				return cenId;
			}
			set	
			{
				cenId = value;
				DictionaryUtil.Add(QueryParameters, "CenId", value);
			}
		}

		[JsonProperty(PropertyName = "VirtualBorderRouterId")]
		public string VirtualBorderRouterId
		{
			get
			{
				return virtualBorderRouterId;
			}
			set	
			{
				virtualBorderRouterId = value;
				DictionaryUtil.Add(QueryParameters, "VirtualBorderRouterId", value);
			}
		}

		[JsonProperty(PropertyName = "Direction")]
		public string Direction
		{
			get
			{
				return direction;
			}
			set	
			{
				direction = value;
				DictionaryUtil.Add(QueryParameters, "Direction", value);
			}
		}

		[JsonProperty(PropertyName = "EndTime")]
		public long? EndTime
		{
			get
			{
				return endTime;
			}
			set	
			{
				endTime = value;
				DictionaryUtil.Add(QueryParameters, "EndTime", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "BeginTime")]
		public long? BeginTime
		{
			get
			{
				return beginTime;
			}
			set	
			{
				beginTime = value;
				DictionaryUtil.Add(QueryParameters, "BeginTime", value.ToString());
			}
		}

		[JsonProperty(PropertyName = "GroupBy")]
		public string GroupBy
		{
			get
			{
				return groupBy;
			}
			set	
			{
				groupBy = value;
				DictionaryUtil.Add(QueryParameters, "GroupBy", value);
			}
		}

		[JsonProperty(PropertyName = "AccountIds")]
		public List<long?> AccountIds
		{
			get
			{
				return accountIds;
			}

			set
			{
				accountIds = value;
				if(accountIds != null)
				{
					for (int depth1 = 0; depth1 < accountIds.Count; depth1++)
					{
						DictionaryUtil.Add(QueryParameters,"AccountIds." + (depth1 + 1), accountIds[depth1]);
					}
				}
			}
		}

		[JsonProperty(PropertyName = "AttachmentId")]
		public string AttachmentId
		{
			get
			{
				return attachmentId;
			}
			set	
			{
				attachmentId = value;
				DictionaryUtil.Add(QueryParameters, "AttachmentId", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override GetVbrFlowTopNResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return GetVbrFlowTopNResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
