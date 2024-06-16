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
using Aliyun.Acs.Sasti;
using Aliyun.Acs.Sasti.Transform;
using Aliyun.Acs.Sasti.Transform.V20200512;

namespace Aliyun.Acs.Sasti.Model.V20200512
{
    public class DescribeFileReportRequest : RpcAcsRequest<DescribeFileReportResponse>
    {
        public DescribeFileReportRequest()
            : base("Sasti", "2020-05-12", "DescribeFileReport")
        {
			Method = MethodType.POST;
        }

		private string field;

		private string serviceLang;

		private string fileHash;

		public string Field
		{
			get
			{
				return field;
			}
			set	
			{
				field = value;
				DictionaryUtil.Add(QueryParameters, "Field", value);
			}
		}

		public string ServiceLang
		{
			get
			{
				return serviceLang;
			}
			set	
			{
				serviceLang = value;
				DictionaryUtil.Add(QueryParameters, "ServiceLang", value);
			}
		}

		public string FileHash
		{
			get
			{
				return fileHash;
			}
			set	
			{
				fileHash = value;
				DictionaryUtil.Add(QueryParameters, "FileHash", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override DescribeFileReportResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return DescribeFileReportResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
