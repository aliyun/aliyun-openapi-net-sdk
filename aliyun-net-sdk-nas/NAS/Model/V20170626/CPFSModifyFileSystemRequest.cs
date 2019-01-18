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
using Aliyun.Acs.NAS.Transform;
using Aliyun.Acs.NAS.Transform.V20170626;
using System.Collections.Generic;

namespace Aliyun.Acs.NAS.Model.V20170626
{
    public class CPFSModifyFileSystemRequest : RpcAcsRequest<CPFSModifyFileSystemResponse>
    {
        public CPFSModifyFileSystemRequest()
            : base("NAS", "2017-06-26", "CPFSModifyFileSystem", "nas", "openAPI")
        {
        }

		private long? bandwidth;

		private string fsId;

		private string fsDesc;

		private long? capacity;

		public long? Bandwidth
		{
			get
			{
				return bandwidth;
			}
			set	
			{
				bandwidth = value;
				DictionaryUtil.Add(QueryParameters, "Bandwidth", value.ToString());
			}
		}

		public string FsId
		{
			get
			{
				return fsId;
			}
			set	
			{
				fsId = value;
				DictionaryUtil.Add(QueryParameters, "FsId", value);
			}
		}

		public string FsDesc
		{
			get
			{
				return fsDesc;
			}
			set	
			{
				fsDesc = value;
				DictionaryUtil.Add(QueryParameters, "FsDesc", value);
			}
		}

		public long? Capacity
		{
			get
			{
				return capacity;
			}
			set	
			{
				capacity = value;
				DictionaryUtil.Add(QueryParameters, "Capacity", value.ToString());
			}
		}

        public override CPFSModifyFileSystemResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return CPFSModifyFileSystemResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}