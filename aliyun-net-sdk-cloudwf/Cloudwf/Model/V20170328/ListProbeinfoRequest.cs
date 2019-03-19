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
using Aliyun.Acs.cloudwf.Transform;
using Aliyun.Acs.cloudwf.Transform.V20170328;

namespace Aliyun.Acs.cloudwf.Model.V20170328
{
    public class ListProbeinfoRequest : RpcAcsRequest<ListProbeinfoResponse>
    {
        public ListProbeinfoRequest()
            : base("cloudwf", "2017-03-28", "ListProbeinfo", "cloudwf", "openAPI")
        {
        }

		private string orderCol;

		private string searchUserMac;

		private string searchSensorMac;

		private int? length;

		private string searchSensorName;

		private int? pageIndex;

		private string orderDir;

		private string accessKeyId;

		public string OrderCol
		{
			get
			{
				return orderCol;
			}
			set	
			{
				orderCol = value;
				DictionaryUtil.Add(QueryParameters, "OrderCol", value);
			}
		}

		public string SearchUserMac
		{
			get
			{
				return searchUserMac;
			}
			set	
			{
				searchUserMac = value;
				DictionaryUtil.Add(QueryParameters, "SearchUserMac", value);
			}
		}

		public string SearchSensorMac
		{
			get
			{
				return searchSensorMac;
			}
			set	
			{
				searchSensorMac = value;
				DictionaryUtil.Add(QueryParameters, "SearchSensorMac", value);
			}
		}

		public int? Length
		{
			get
			{
				return length;
			}
			set	
			{
				length = value;
				DictionaryUtil.Add(QueryParameters, "Length", value.ToString());
			}
		}

		public string SearchSensorName
		{
			get
			{
				return searchSensorName;
			}
			set	
			{
				searchSensorName = value;
				DictionaryUtil.Add(QueryParameters, "SearchSensorName", value);
			}
		}

		public int? PageIndex
		{
			get
			{
				return pageIndex;
			}
			set	
			{
				pageIndex = value;
				DictionaryUtil.Add(QueryParameters, "PageIndex", value.ToString());
			}
		}

		public string OrderDir
		{
			get
			{
				return orderDir;
			}
			set	
			{
				orderDir = value;
				DictionaryUtil.Add(QueryParameters, "OrderDir", value);
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

        public override ListProbeinfoResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ListProbeinfoResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
