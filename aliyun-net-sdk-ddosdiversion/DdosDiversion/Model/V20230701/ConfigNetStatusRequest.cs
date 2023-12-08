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
using Aliyun.Acs.DdosDiversion;
using Aliyun.Acs.DdosDiversion.Transform;
using Aliyun.Acs.DdosDiversion.Transform.V20230701;

namespace Aliyun.Acs.DdosDiversion.Model.V20230701
{
    public class ConfigNetStatusRequest : RpcAcsRequest<ConfigNetStatusResponse>
    {
        public ConfigNetStatusRequest()
            : base("DdosDiversion", "2023-07-01", "ConfigNetStatus")
        {
			Method = MethodType.POST;
        }

		private List<string> regions = new List<string>(){ };

		private List<string> subNets = new List<string>(){ };

		private string net;

		private string saleId;

		private string status;

		public List<string> Regions
		{
			get
			{
				return regions;
			}

			set
			{
				regions = value;
				if(regions != null)
				{
					for (int depth1 = 0; depth1 < regions.Count; depth1++)
					{
						DictionaryUtil.Add(QueryParameters,"Regions." + (depth1 + 1), regions[depth1]);
					}
				}
			}
		}

		public List<string> SubNets
		{
			get
			{
				return subNets;
			}

			set
			{
				subNets = value;
				if(subNets != null)
				{
					for (int depth1 = 0; depth1 < subNets.Count; depth1++)
					{
						DictionaryUtil.Add(QueryParameters,"SubNets." + (depth1 + 1), subNets[depth1]);
					}
				}
			}
		}

		public string Net
		{
			get
			{
				return net;
			}
			set	
			{
				net = value;
				DictionaryUtil.Add(QueryParameters, "Net", value);
			}
		}

		public string SaleId
		{
			get
			{
				return saleId;
			}
			set	
			{
				saleId = value;
				DictionaryUtil.Add(QueryParameters, "SaleId", value);
			}
		}

		public string Status
		{
			get
			{
				return status;
			}
			set	
			{
				status = value;
				DictionaryUtil.Add(QueryParameters, "Status", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override ConfigNetStatusResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ConfigNetStatusResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
