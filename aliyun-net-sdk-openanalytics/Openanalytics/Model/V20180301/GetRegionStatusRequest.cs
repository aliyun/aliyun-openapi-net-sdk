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
using Aliyun.Acs.openanalytics.Transform;
using Aliyun.Acs.openanalytics.Transform.V20180301;

namespace Aliyun.Acs.openanalytics.Model.V20180301
{
    public class GetRegionStatusRequest : RpcAcsRequest<GetRegionStatusResponse>
    {
        public GetRegionStatusRequest()
            : base("openanalytics", "2018-03-01", "GetRegionStatus", "openanalytics", "openAPI")
        {
        }

		private string regionID;

		private long? targetUid;

		public string RegionID
		{
			get
			{
				return regionID;
			}
			set	
			{
				regionID = value;
				DictionaryUtil.Add(BodyParameters, "RegionID", value);
			}
		}

		public long? TargetUid
		{
			get
			{
				return targetUid;
			}
			set	
			{
				targetUid = value;
				DictionaryUtil.Add(BodyParameters, "TargetUid", value.ToString());
			}
		}

        public override GetRegionStatusResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return GetRegionStatusResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
