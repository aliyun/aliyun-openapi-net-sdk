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
using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.Iot.Transform;
using Aliyun.Acs.Iot.Transform.V20160530;
using System.Collections.Generic;

namespace Aliyun.Acs.Iot.Model.V20160530
{
    public class UpdateProductRequest : RpcAcsRequest<UpdateProductResponse>
    {
        public UpdateProductRequest()
            : base("Iot", "2016-05-30", "UpdateProduct")
        {
        }

		private string productName;

		private string productDesc;

		private string extProps;

		private long? catId;

		private string productKey;

		public string ProductName
		{
			get
			{
				return productName;
			}
			set	
			{
				productName = value;
				DictionaryUtil.Add(QueryParameters, "ProductName", value);
			}
		}

		public string ProductDesc
		{
			get
			{
				return productDesc;
			}
			set	
			{
				productDesc = value;
				DictionaryUtil.Add(QueryParameters, "ProductDesc", value);
			}
		}

		public string ExtProps
		{
			get
			{
				return extProps;
			}
			set	
			{
				extProps = value;
				DictionaryUtil.Add(QueryParameters, "ExtProps", value);
			}
		}

		public long? CatId
		{
			get
			{
				return catId;
			}
			set	
			{
				catId = value;
				DictionaryUtil.Add(QueryParameters, "CatId", value.ToString());
			}
		}

		public string ProductKey
		{
			get
			{
				return productKey;
			}
			set	
			{
				productKey = value;
				DictionaryUtil.Add(QueryParameters, "ProductKey", value);
			}
		}

        public override UpdateProductResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return UpdateProductResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}