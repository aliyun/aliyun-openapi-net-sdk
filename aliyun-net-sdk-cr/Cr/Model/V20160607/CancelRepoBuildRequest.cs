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
using Aliyun.Acs.cr.Transform;
using Aliyun.Acs.cr.Transform.V20160607;

namespace Aliyun.Acs.cr.Model.V20160607
{
    public class CancelRepoBuildRequest : RoaAcsRequest<CancelRepoBuildResponse>
    {
        public CancelRepoBuildRequest()
            : base("cr", "2016-06-07", "CancelRepoBuild", "cr", "openAPI")
        {
			UriPattern = "/repos/[RepoNamespace]/[RepoName]/build/[BuildId]/cancel";
			Method = MethodType.POST;
        }

		private string repoNamespace;

		private string repoName;

		private string buildId;

		public string RepoNamespace
		{
			get
			{
				return repoNamespace;
			}
			set	
			{
				repoNamespace = value;
				DictionaryUtil.Add(PathParameters, "RepoNamespace", value);
			}
		}

		public string RepoName
		{
			get
			{
				return repoName;
			}
			set	
			{
				repoName = value;
				DictionaryUtil.Add(PathParameters, "RepoName", value);
			}
		}

		public string BuildId
		{
			get
			{
				return buildId;
			}
			set	
			{
				buildId = value;
				DictionaryUtil.Add(PathParameters, "BuildId", value);
			}
		}

        public override CancelRepoBuildResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return CancelRepoBuildResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
