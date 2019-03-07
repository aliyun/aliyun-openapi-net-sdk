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
using Aliyun.Acs.Actiontrail.Transform;
using Aliyun.Acs.Actiontrail.Transform.V20171204;
using System.Collections.Generic;

namespace Aliyun.Acs.Actiontrail.Model.V20171204
{
    public class UpdateTrailRequest : RpcAcsRequest<UpdateTrailResponse>
    {
        public UpdateTrailRequest()
            : base("Actiontrail", "2017-12-04", "UpdateTrail", "actiontrail", "openAPI")
        {
        }

		private string slsProjectArn;

		private string slsWriteRoleArn;

		private string roleName;

		private string name;

		private string ossBucketName;

		private string ossKeyPrefix;

		private string eventRW;

		private string accessKeyId;

		public string SlsProjectArn
		{
			get
			{
				return slsProjectArn;
			}
			set	
			{
				slsProjectArn = value;
				DictionaryUtil.Add(QueryParameters, "SlsProjectArn", value);
			}
		}

		public string SlsWriteRoleArn
		{
			get
			{
				return slsWriteRoleArn;
			}
			set	
			{
				slsWriteRoleArn = value;
				DictionaryUtil.Add(QueryParameters, "SlsWriteRoleArn", value);
			}
		}

		public string RoleName
		{
			get
			{
				return roleName;
			}
			set	
			{
				roleName = value;
				DictionaryUtil.Add(QueryParameters, "RoleName", value);
			}
		}

		public string Name
		{
			get
			{
				return name;
			}
			set	
			{
				name = value;
				DictionaryUtil.Add(QueryParameters, "Name", value);
			}
		}

		public string OssBucketName
		{
			get
			{
				return ossBucketName;
			}
			set	
			{
				ossBucketName = value;
				DictionaryUtil.Add(QueryParameters, "OssBucketName", value);
			}
		}

		public string OssKeyPrefix
		{
			get
			{
				return ossKeyPrefix;
			}
			set	
			{
				ossKeyPrefix = value;
				DictionaryUtil.Add(QueryParameters, "OssKeyPrefix", value);
			}
		}

		public string EventRW
		{
			get
			{
				return eventRW;
			}
			set	
			{
				eventRW = value;
				DictionaryUtil.Add(QueryParameters, "EventRW", value);
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

        public override UpdateTrailResponse GetResponse(Core.Transform.UnmarshallerContext unmarshallerContext)
        {
            return UpdateTrailResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}