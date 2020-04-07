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
using Aliyun.Acs.cusanalytic_sc_online;
using Aliyun.Acs.cusanalytic_sc_online.Transform;
using Aliyun.Acs.cusanalytic_sc_online.Transform.V20190524;

namespace Aliyun.Acs.cusanalytic_sc_online.Model.V20190524
{
    public class MemberSynchronousRequest : RpcAcsRequest<MemberSynchronousResponse>
    {
        public MemberSynchronousRequest()
            : base("cusanalytic_sc_online", "2019-05-24", "MemberSynchronous")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Endpoint.endpointRegionalType, null);
            }
        }

		private long? ukId;

		private string faceUrls;

		private long? storeId;

		private string type;

		private long? custId;

		public long? UkId
		{
			get
			{
				return ukId;
			}
			set	
			{
				ukId = value;
				DictionaryUtil.Add(BodyParameters, "UkId", value.ToString());
			}
		}

		public string FaceUrls
		{
			get
			{
				return faceUrls;
			}
			set	
			{
				faceUrls = value;
				DictionaryUtil.Add(BodyParameters, "FaceUrls", value);
			}
		}

		public long? StoreId
		{
			get
			{
				return storeId;
			}
			set	
			{
				storeId = value;
				DictionaryUtil.Add(BodyParameters, "StoreId", value.ToString());
			}
		}

		public string Type
		{
			get
			{
				return type;
			}
			set	
			{
				type = value;
				DictionaryUtil.Add(BodyParameters, "Type", value);
			}
		}

		public long? CustId
		{
			get
			{
				return custId;
			}
			set	
			{
				custId = value;
				DictionaryUtil.Add(BodyParameters, "CustId", value.ToString());
			}
		}

        public override MemberSynchronousResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return MemberSynchronousResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
