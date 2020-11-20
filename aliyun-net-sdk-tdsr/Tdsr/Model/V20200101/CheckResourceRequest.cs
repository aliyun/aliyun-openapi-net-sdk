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
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.tdsr;
using Aliyun.Acs.tdsr.Transform;
using Aliyun.Acs.tdsr.Transform.V20200101;

namespace Aliyun.Acs.tdsr.Model.V20200101
{
    public class CheckResourceRequest : RpcAcsRequest<CheckResourceResponse>
    {
        public CheckResourceRequest()
            : base("tdsr", "2020-01-01", "CheckResource")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.tdsr.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.tdsr.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string country;

		private long? hid;

		private long? level;

		private string invoker;

		private string message;

		private string url;

		private bool? success;

		private bool? interrupt;

		private string gmtWakeup;

		private string pk;

		private string bid;

		private string prompt;

		private string taskExtraData;

		private string taskIdentifier;

		public string Country
		{
			get
			{
				return country;
			}
			set	
			{
				country = value;
				DictionaryUtil.Add(QueryParameters, "Country", value);
			}
		}

		public long? Hid
		{
			get
			{
				return hid;
			}
			set	
			{
				hid = value;
				DictionaryUtil.Add(QueryParameters, "Hid", value.ToString());
			}
		}

		public long? Level
		{
			get
			{
				return level;
			}
			set	
			{
				level = value;
				DictionaryUtil.Add(QueryParameters, "Level", value.ToString());
			}
		}

		public string Invoker
		{
			get
			{
				return invoker;
			}
			set	
			{
				invoker = value;
				DictionaryUtil.Add(QueryParameters, "Invoker", value);
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
				DictionaryUtil.Add(QueryParameters, "Message", value);
			}
		}

		public string Url
		{
			get
			{
				return url;
			}
			set	
			{
				url = value;
				DictionaryUtil.Add(QueryParameters, "Url", value);
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
				DictionaryUtil.Add(QueryParameters, "Success", value.ToString());
			}
		}

		public bool? Interrupt
		{
			get
			{
				return interrupt;
			}
			set	
			{
				interrupt = value;
				DictionaryUtil.Add(QueryParameters, "Interrupt", value.ToString());
			}
		}

		public string GmtWakeup
		{
			get
			{
				return gmtWakeup;
			}
			set	
			{
				gmtWakeup = value;
				DictionaryUtil.Add(QueryParameters, "GmtWakeup", value);
			}
		}

		public string Pk
		{
			get
			{
				return pk;
			}
			set	
			{
				pk = value;
				DictionaryUtil.Add(QueryParameters, "Pk", value);
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
				DictionaryUtil.Add(QueryParameters, "Bid", value);
			}
		}

		public string Prompt
		{
			get
			{
				return prompt;
			}
			set	
			{
				prompt = value;
				DictionaryUtil.Add(QueryParameters, "Prompt", value);
			}
		}

		public string TaskExtraData
		{
			get
			{
				return taskExtraData;
			}
			set	
			{
				taskExtraData = value;
				DictionaryUtil.Add(QueryParameters, "TaskExtraData", value);
			}
		}

		public string TaskIdentifier
		{
			get
			{
				return taskIdentifier;
			}
			set	
			{
				taskIdentifier = value;
				DictionaryUtil.Add(QueryParameters, "TaskIdentifier", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override CheckResourceResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CheckResourceResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
