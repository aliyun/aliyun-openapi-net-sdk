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
using Aliyun.Acs.CCC;
using Aliyun.Acs.CCC.Transform;
using Aliyun.Acs.CCC.Transform.V20200701;

namespace Aliyun.Acs.CCC.Model.V20200701
{
    public class ImportDoNotCallNumbersRequest : RpcAcsRequest<ImportDoNotCallNumbersResponse>
    {
        public ImportDoNotCallNumbersRequest()
            : base("CCC", "2020-07-01", "ImportDoNotCallNumbers")
        {
            if (this.GetType().GetProperty("ProductEndpointMap") != null && this.GetType().GetProperty("ProductEndpointType") != null)
            {
                this.GetType().GetProperty("ProductEndpointMap").SetValue(this, Aliyun.Acs.CCC.Endpoint.endpointMap, null);
                this.GetType().GetProperty("ProductEndpointType").SetValue(this, Aliyun.Acs.CCC.Endpoint.endpointRegionalType, null);
            }
			Method = MethodType.POST;
        }

		private string remark;

		private string numberList;

		private string instanceId;

		private string filePath;

		public string Remark
		{
			get
			{
				return remark;
			}
			set	
			{
				remark = value;
				DictionaryUtil.Add(QueryParameters, "Remark", value);
			}
		}

		public string NumberList
		{
			get
			{
				return numberList;
			}
			set	
			{
				numberList = value;
				DictionaryUtil.Add(QueryParameters, "NumberList", value);
			}
		}

		public string InstanceId
		{
			get
			{
				return instanceId;
			}
			set	
			{
				instanceId = value;
				DictionaryUtil.Add(QueryParameters, "InstanceId", value);
			}
		}

		public string FilePath
		{
			get
			{
				return filePath;
			}
			set	
			{
				filePath = value;
				DictionaryUtil.Add(QueryParameters, "FilePath", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override ImportDoNotCallNumbersResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ImportDoNotCallNumbersResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
