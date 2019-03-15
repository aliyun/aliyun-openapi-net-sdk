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
using Aliyun.Acs.Crm.Model.V20150408;

namespace Aliyun.Acs.Crm.Transform.V20150408
{
    public class BatchGetAliyunIdByAliyunPkResponseUnmarshaller
    {
        public static BatchGetAliyunIdByAliyunPkResponse Unmarshall(UnmarshallerContext context)
        {
			BatchGetAliyunIdByAliyunPkResponse batchGetAliyunIdByAliyunPkResponse = new BatchGetAliyunIdByAliyunPkResponse();

			batchGetAliyunIdByAliyunPkResponse.HttpResponse = context.HttpResponse;
			batchGetAliyunIdByAliyunPkResponse.RequestId = context.StringValue("BatchGetAliyunIdByAliyunPk.RequestId");

			List<BatchGetAliyunIdByAliyunPkResponse.BatchGetAliyunIdByAliyunPk_ProfileItem> batchGetAliyunIdByAliyunPkResponse_profileList = new List<BatchGetAliyunIdByAliyunPkResponse.BatchGetAliyunIdByAliyunPk_ProfileItem>();
			for (int i = 0; i < context.Length("BatchGetAliyunIdByAliyunPk.ProfileList.Length"); i++) {
				BatchGetAliyunIdByAliyunPkResponse.BatchGetAliyunIdByAliyunPk_ProfileItem profileItem = new BatchGetAliyunIdByAliyunPkResponse.BatchGetAliyunIdByAliyunPk_ProfileItem();
				profileItem.AliyunId = context.StringValue("BatchGetAliyunIdByAliyunPk.ProfileList["+ i +"].AliyunId");
				profileItem.AliyunPk = context.StringValue("BatchGetAliyunIdByAliyunPk.ProfileList["+ i +"].AliyunPk");

				batchGetAliyunIdByAliyunPkResponse_profileList.Add(profileItem);
			}
			batchGetAliyunIdByAliyunPkResponse.ProfileList = batchGetAliyunIdByAliyunPkResponse_profileList;
        
			return batchGetAliyunIdByAliyunPkResponse;
        }
    }
}
