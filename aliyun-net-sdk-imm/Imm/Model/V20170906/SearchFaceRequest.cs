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
using Aliyun.Acs.imm.Transform;
using Aliyun.Acs.imm.Transform.V20170906;

namespace Aliyun.Acs.imm.Model.V20170906
{
    public class SearchFaceRequest : RpcAcsRequest<SearchFaceResponse>
    {
        public SearchFaceRequest()
            : base("imm", "2017-09-06", "SearchFace", "imm", "openAPI")
        {
        }

		private int? resultNum;

		private string project;

		private string searchThresholdLevel;

		private bool? isThreshold;

		private string groupName;

		private string srcUri;

		public int? ResultNum
		{
			get
			{
				return resultNum;
			}
			set	
			{
				resultNum = value;
				DictionaryUtil.Add(QueryParameters, "ResultNum", value.ToString());
			}
		}

		public string Project
		{
			get
			{
				return project;
			}
			set	
			{
				project = value;
				DictionaryUtil.Add(QueryParameters, "Project", value);
			}
		}

		public string SearchThresholdLevel
		{
			get
			{
				return searchThresholdLevel;
			}
			set	
			{
				searchThresholdLevel = value;
				DictionaryUtil.Add(QueryParameters, "SearchThresholdLevel", value);
			}
		}

		public bool? IsThreshold
		{
			get
			{
				return isThreshold;
			}
			set	
			{
				isThreshold = value;
				DictionaryUtil.Add(QueryParameters, "IsThreshold", value.ToString());
			}
		}

		public string GroupName
		{
			get
			{
				return groupName;
			}
			set	
			{
				groupName = value;
				DictionaryUtil.Add(QueryParameters, "GroupName", value);
			}
		}

		public string SrcUri
		{
			get
			{
				return srcUri;
			}
			set	
			{
				srcUri = value;
				DictionaryUtil.Add(QueryParameters, "SrcUri", value);
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override SearchFaceResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return SearchFaceResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
