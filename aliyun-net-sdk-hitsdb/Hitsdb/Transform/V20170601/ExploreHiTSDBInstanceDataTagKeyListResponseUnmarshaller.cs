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
using System;
using System.Collections.Generic;

using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.hitsdb.Model.V20170601;

namespace Aliyun.Acs.hitsdb.Transform.V20170601
{
    public class ExploreHiTSDBInstanceDataTagKeyListResponseUnmarshaller
    {
        public static ExploreHiTSDBInstanceDataTagKeyListResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ExploreHiTSDBInstanceDataTagKeyListResponse exploreHiTSDBInstanceDataTagKeyListResponse = new ExploreHiTSDBInstanceDataTagKeyListResponse();

			exploreHiTSDBInstanceDataTagKeyListResponse.HttpResponse = _ctx.HttpResponse;
			exploreHiTSDBInstanceDataTagKeyListResponse.RequestId = _ctx.StringValue("ExploreHiTSDBInstanceDataTagKeyList.RequestId");
			exploreHiTSDBInstanceDataTagKeyListResponse.InstanceId = _ctx.StringValue("ExploreHiTSDBInstanceDataTagKeyList.InstanceId");

			List<ExploreHiTSDBInstanceDataTagKeyListResponse.ExploreHiTSDBInstanceDataTagKeyList_Data> exploreHiTSDBInstanceDataTagKeyListResponse_tagKeyList = new List<ExploreHiTSDBInstanceDataTagKeyListResponse.ExploreHiTSDBInstanceDataTagKeyList_Data>();
			for (int i = 0; i < _ctx.Length("ExploreHiTSDBInstanceDataTagKeyList.TagKeyList.Length"); i++) {
				ExploreHiTSDBInstanceDataTagKeyListResponse.ExploreHiTSDBInstanceDataTagKeyList_Data data = new ExploreHiTSDBInstanceDataTagKeyListResponse.ExploreHiTSDBInstanceDataTagKeyList_Data();
				data.TagKey = _ctx.StringValue("ExploreHiTSDBInstanceDataTagKeyList.TagKeyList["+ i +"].TagKey");

				exploreHiTSDBInstanceDataTagKeyListResponse_tagKeyList.Add(data);
			}
			exploreHiTSDBInstanceDataTagKeyListResponse.TagKeyList = exploreHiTSDBInstanceDataTagKeyListResponse_tagKeyList;
        
			return exploreHiTSDBInstanceDataTagKeyListResponse;
        }
    }
}
