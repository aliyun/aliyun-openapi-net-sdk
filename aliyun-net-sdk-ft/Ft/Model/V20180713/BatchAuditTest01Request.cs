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
using Aliyun.Acs.Ft;
using Aliyun.Acs.Ft.Transform;
using Aliyun.Acs.Ft.Transform.V20180713;

namespace Aliyun.Acs.Ft.Model.V20180713
{
    public class BatchAuditTest01Request : RpcAcsRequest<BatchAuditTest01Response>
    {
        public BatchAuditTest01Request()
            : base("Ft", "2018-07-13", "BatchAuditTest01")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.Ft.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.Ft.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string demo01;

		private bool? test010101;

		private string name;

		private string batchAuditTest01;

		public string Demo01
		{
			get
			{
				return demo01;
			}
			set	
			{
				demo01 = value;
				DictionaryUtil.Add(QueryParameters, "Demo01", value);
			}
		}

		public bool? Test010101
		{
			get
			{
				return test010101;
			}
			set	
			{
				test010101 = value;
				DictionaryUtil.Add(BodyParameters, "Test010101", value.ToString());
			}
		}

		public string Name
		{
			get
			{
				return name;
			}
			set	
			{
				name = value;
				DictionaryUtil.Add(QueryParameters, "Name", value);
			}
		}

		public string BatchAuditTest01
		{
			get
			{
				return batchAuditTest01;
			}
			set	
			{
				batchAuditTest01 = value;
				DictionaryUtil.Add(QueryParameters, "BatchAuditTest01", value);
			}
		}

        public override BatchAuditTest01Response GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return BatchAuditTest01ResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
