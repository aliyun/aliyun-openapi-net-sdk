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
using Aliyun.Acs.cloudwf.Transform;
using Aliyun.Acs.cloudwf.Transform.V20170328;

namespace Aliyun.Acs.cloudwf.Model.V20170328
{
    public class ConfigAutoRenewRequest : RpcAcsRequest<ConfigAutoRenewResponse>
    {
        public ConfigAutoRenewRequest()
            : base("cloudwf", "2017-03-28", "ConfigAutoRenew", "cloudwf", "openAPI")
        {
        }

		private int? offsetDays;

		private int? months;

		private bool? autoRenew;

		private List<string> apLists;

		private string accessKeyId;

		public int? OffsetDays
		{
			get
			{
				return offsetDays;
			}
			set	
			{
				offsetDays = value;
				DictionaryUtil.Add(QueryParameters, "OffsetDays", value.ToString());
			}
		}

		public int? Months
		{
			get
			{
				return months;
			}
			set	
			{
				months = value;
				DictionaryUtil.Add(QueryParameters, "Months", value.ToString());
			}
		}

		public bool? AutoRenew
		{
			get
			{
				return autoRenew;
			}
			set	
			{
				autoRenew = value;
				DictionaryUtil.Add(QueryParameters, "AutoRenew", value.ToString());
			}
		}

		public List<string> ApLists
		{
			get
			{
				return apLists;
			}

			set
			{
				apLists = value;
				for (int i = 0; i < apLists.Count; i++)
				{
					DictionaryUtil.Add(QueryParameters,"ApList." + (i + 1) , apLists[i]);
				}
			}
		}

		public string AccessKeyId
		{
			get
			{
				return accessKeyId;
			}
			set	
			{
				accessKeyId = value;
				DictionaryUtil.Add(QueryParameters, "AccessKeyId", value);
			}
		}

        public override ConfigAutoRenewResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ConfigAutoRenewResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
