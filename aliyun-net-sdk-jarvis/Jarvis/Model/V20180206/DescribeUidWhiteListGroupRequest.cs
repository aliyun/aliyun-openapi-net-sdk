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
using Aliyun.Acs.jarvis.Transform;
using Aliyun.Acs.jarvis.Transform.V20180206;
using System.Collections.Generic;

namespace Aliyun.Acs.jarvis.Model.V20180206
{
    public class DescribeUidWhiteListGroupRequest : RpcAcsRequest<DescribeUidWhiteListGroupResponse>
    {
        public DescribeUidWhiteListGroupRequest()
            : base("jarvis", "2018-02-06", "DescribeUidWhiteListGroup")
        {
        }

		private string sourceIp;

		private int? pageSize;

		private int? currentPage;

		private int? whiteListType;

		private string dstIP;

		private string lang;

		private string srcUid;

		private string status;

		private string sourceCode;

		public string SourceIp
		{
			get
			{
				return sourceIp;
			}
			set	
			{
				sourceIp = value;
				DictionaryUtil.Add(QueryParameters, "SourceIp", value);
			}
		}

		public int? PageSize
		{
			get
			{
				return pageSize;
			}
			set	
			{
				pageSize = value;
				DictionaryUtil.Add(QueryParameters, "PageSize", value.ToString());
			}
		}

		public int? CurrentPage
		{
			get
			{
				return currentPage;
			}
			set	
			{
				currentPage = value;
				DictionaryUtil.Add(QueryParameters, "CurrentPage", value.ToString());
			}
		}

		public int? WhiteListType
		{
			get
			{
				return whiteListType;
			}
			set	
			{
				whiteListType = value;
				DictionaryUtil.Add(QueryParameters, "WhiteListType", value.ToString());
			}
		}

		public string DstIP
		{
			get
			{
				return dstIP;
			}
			set	
			{
				dstIP = value;
				DictionaryUtil.Add(QueryParameters, "DstIP", value);
			}
		}

		public string Lang
		{
			get
			{
				return lang;
			}
			set	
			{
				lang = value;
				DictionaryUtil.Add(QueryParameters, "Lang", value);
			}
		}

		public string SrcUid
		{
			get
			{
				return srcUid;
			}
			set	
			{
				srcUid = value;
				DictionaryUtil.Add(QueryParameters, "SrcUid", value);
			}
		}

		public string Status
		{
			get
			{
				return status;
			}
			set	
			{
				status = value;
				DictionaryUtil.Add(QueryParameters, "Status", value);
			}
		}

		public string SourceCode
		{
			get
			{
				return sourceCode;
			}
			set	
			{
				sourceCode = value;
				DictionaryUtil.Add(QueryParameters, "SourceCode", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override DescribeUidWhiteListGroupResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return DescribeUidWhiteListGroupResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}