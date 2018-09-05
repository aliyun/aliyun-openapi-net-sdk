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
using Aliyun.Acs.Iot.Transform.V20180120;
using System.Collections.Generic;

namespace Aliyun.Acs.Iot.Model.V20180120
{
    public class CreateProductRequest : RpcAcsRequest<CreateProductResponse>
    {
        public CreateProductRequest()
            : base("Iot", "2018-01-20", "CreateProduct")
        {
        }

		private int? dataFormat;

		private int? nodeType;

		private bool? id2;

		private string productName;

		private string description;

		private string protocolType;

		private string aliyunCommodityCode;

		private long? categoryId;

		private string accessKeyId;

		public int? DataFormat
		{
			get
			{
				return dataFormat;
			}
			set	
			{
				dataFormat = value;
				DictionaryUtil.Add(QueryParameters, "DataFormat", value.ToString());
			}
		}

		public int? NodeType
		{
			get
			{
				return nodeType;
			}
			set	
			{
				nodeType = value;
				DictionaryUtil.Add(QueryParameters, "NodeType", value.ToString());
			}
		}

		public bool? Id2
		{
			get
			{
				return id2;
			}
			set	
			{
				id2 = value;
				DictionaryUtil.Add(QueryParameters, "Id2", value.ToString());
			}
		}

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

		public string Description
		{
			get
			{
				return description;
			}
			set	
			{
				description = value;
				DictionaryUtil.Add(QueryParameters, "Description", value);
			}
		}

		public string ProtocolType
		{
			get
			{
				return protocolType;
			}
			set	
			{
				protocolType = value;
				DictionaryUtil.Add(QueryParameters, "ProtocolType", value);
			}
		}

		public string AliyunCommodityCode
		{
			get
			{
				return aliyunCommodityCode;
			}
			set	
			{
				aliyunCommodityCode = value;
				DictionaryUtil.Add(QueryParameters, "AliyunCommodityCode", value);
			}
		}

		public long? CategoryId
		{
			get
			{
				return categoryId;
			}
			set	
			{
				categoryId = value;
				DictionaryUtil.Add(QueryParameters, "CategoryId", value.ToString());
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

        public override CreateProductResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return CreateProductResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}