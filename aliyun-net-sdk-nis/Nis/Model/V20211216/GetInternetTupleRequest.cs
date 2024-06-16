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
    public class GetInternetTupleRequest : RpcAcsRequest<GetInternetTupleResponse>
    {
        public GetInternetTupleRequest()
            : base("nis", "2021-12-16", "GetInternetTuple", "networkana", "openAPI")
        {
			Method = MethodType.POST;
        }

		private string otherPort;

		private string cloudIsp;

		private int? topN;

		private string cloudPort;

		private string protocol;

		private string otherIp;

		private List<string> instanceList = new List<string>(){ };

		private string orderBy;

		private string sort;

		private bool? useMultiAccount;

		private string instanceId;

		private int? tupleType;

		private string cloudIp;

		private List<string> cloudIpList = new List<string>(){ };

		private string otherIsp;

		private string otherCountry;

		private string direction;

		private long? endTime;

		private long? beginTime;

		private string otherCity;

		private List<string> accountIdss = new List<string>(){ };

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

		[JsonProperty(PropertyName = "CloudIsp")]
		public string CloudIsp
		{
			get
			{
				return cloudIsp;
			}
			set	
			{
				cloudIsp = value;
				DictionaryUtil.Add(QueryParameters, "CloudIsp", value);
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

		[JsonProperty(PropertyName = "InstanceList")]
		public List<string> InstanceList
		{
			get
			{
				return instanceList;
			}

			set
			{
				instanceList = value;
				if(instanceList != null)
				{
					for (int depth1 = 0; depth1 < instanceList.Count; depth1++)
					{
						DictionaryUtil.Add(QueryParameters,"InstanceList." + (depth1 + 1), instanceList[depth1]);
					}
				}
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

		[JsonProperty(PropertyName = "InstanceId")]
		public string InstanceId
		{
			get
			{
				return instanceId;
			}
			set	
			{
				instanceId = value;
				DictionaryUtil.Add(QueryParameters, "InstanceId", value);
			}
		}

		[JsonProperty(PropertyName = "TupleType")]
		public int? TupleType
		{
			get
			{
				return tupleType;
			}
			set	
			{
				tupleType = value;
				DictionaryUtil.Add(QueryParameters, "TupleType", value.ToString());
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

		[JsonProperty(PropertyName = "CloudIpList")]
		public List<string> CloudIpList
		{
			get
			{
				return cloudIpList;
			}

			set
			{
				cloudIpList = value;
				if(cloudIpList != null)
				{
					for (int depth1 = 0; depth1 < cloudIpList.Count; depth1++)
					{
						DictionaryUtil.Add(QueryParameters,"CloudIpList." + (depth1 + 1), cloudIpList[depth1]);
					}
				}
			}
		}

		[JsonProperty(PropertyName = "OtherIsp")]
		public string OtherIsp
		{
			get
			{
				return otherIsp;
			}
			set	
			{
				otherIsp = value;
				DictionaryUtil.Add(QueryParameters, "OtherIsp", value);
			}
		}

		[JsonProperty(PropertyName = "OtherCountry")]
		public string OtherCountry
		{
			get
			{
				return otherCountry;
			}
			set	
			{
				otherCountry = value;
				DictionaryUtil.Add(QueryParameters, "OtherCountry", value);
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

		[JsonProperty(PropertyName = "OtherCity")]
		public string OtherCity
		{
			get
			{
				return otherCity;
			}
			set	
			{
				otherCity = value;
				DictionaryUtil.Add(QueryParameters, "OtherCity", value);
			}
		}

		[JsonProperty(PropertyName = "AccountIds")]
		public List<string> AccountIdss
		{
			get
			{
				return accountIdss;
			}

			set
			{
				accountIdss = value;
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override GetInternetTupleResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return GetInternetTupleResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
