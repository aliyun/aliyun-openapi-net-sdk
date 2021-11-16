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
using Aliyun.Acs.dataworks_public;
using Aliyun.Acs.dataworks_public.Transform;
using Aliyun.Acs.dataworks_public.Transform.V20200518;

namespace Aliyun.Acs.dataworks_public.Model.V20200518
{
    public class ListDagsRequest : RpcAcsRequest<ListDagsResponse>
    {
        public ListDagsRequest()
            : base("dataworks-public", "2020-05-18", "ListDags")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.dataworks_public.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.dataworks_public.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string projectEnv;

		private long? opSeq;

		public string ProjectEnv
		{
			get
			{
				return projectEnv;
			}
			set	
			{
				projectEnv = value;
				DictionaryUtil.Add(BodyParameters, "ProjectEnv", value);
			}
		}

		public long? OpSeq
		{
			get
			{
				return opSeq;
			}
			set	
			{
				opSeq = value;
				DictionaryUtil.Add(BodyParameters, "OpSeq", value.ToString());
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override ListDagsResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ListDagsResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
