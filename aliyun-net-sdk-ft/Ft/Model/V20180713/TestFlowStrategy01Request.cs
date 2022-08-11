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
using Aliyun.Acs.Ft;
using Aliyun.Acs.Ft.Transform;
using Aliyun.Acs.Ft.Transform.V20180713;

namespace Aliyun.Acs.Ft.Model.V20180713
{
    public class TestFlowStrategy01Request : RpcAcsRequest<TestFlowStrategy01Response>
    {
        public TestFlowStrategy01Request()
            : base("Ft", "2018-07-13", "TestFlowStrategy01")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Ft.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Ft.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.PUT;
        }

		private List<object> names;

		public List<object> Names
		{
			get
			{
				return names;
			}
			set	
			{
				names = value;
				DictionaryUtil.Add(BodyParameters, "Names", JsonConvert.SerializeObject(value));
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override TestFlowStrategy01Response GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return TestFlowStrategy01ResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
