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
using Aliyun.Acs.Trademark.Transform;
using Aliyun.Acs.Trademark.Transform.V20180724;

namespace Aliyun.Acs.Trademark.Model.V20180724
{
    public class CombineLoaRequest : RpcAcsRequest<CombineLoaResponse>
    {
        public CombineLoaRequest()
            : base("Trademark", "2018-07-24", "CombineLoa", "trademark", "openAPI")
        {
        }

		private string trademarkName;

		private string materialName;

		private string address;

		private string nationality;

		private string tmProduceType;

		private string materialId;

		public string TrademarkName
		{
			get
			{
				return trademarkName;
			}
			set	
			{
				trademarkName = value;
				DictionaryUtil.Add(QueryParameters, "TrademarkName", value);
			}
		}

		public string MaterialName
		{
			get
			{
				return materialName;
			}
			set	
			{
				materialName = value;
				DictionaryUtil.Add(QueryParameters, "MaterialName", value);
			}
		}

		public string Address
		{
			get
			{
				return address;
			}
			set	
			{
				address = value;
				DictionaryUtil.Add(QueryParameters, "Address", value);
			}
		}

		public string Nationality
		{
			get
			{
				return nationality;
			}
			set	
			{
				nationality = value;
				DictionaryUtil.Add(QueryParameters, "Nationality", value);
			}
		}

		public string TmProduceType
		{
			get
			{
				return tmProduceType;
			}
			set	
			{
				tmProduceType = value;
				DictionaryUtil.Add(QueryParameters, "TmProduceType", value);
			}
		}

		public string MaterialId
		{
			get
			{
				return materialId;
			}
			set	
			{
				materialId = value;
				DictionaryUtil.Add(QueryParameters, "MaterialId", value);
			}
		}

        public override CombineLoaResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CombineLoaResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
