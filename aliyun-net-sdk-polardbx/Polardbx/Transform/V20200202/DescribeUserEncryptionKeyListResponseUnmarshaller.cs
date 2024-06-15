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
using Aliyun.Acs.polardbx.Model.V20200202;

namespace Aliyun.Acs.polardbx.Transform.V20200202
{
    public class DescribeUserEncryptionKeyListResponseUnmarshaller
    {
        public static DescribeUserEncryptionKeyListResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeUserEncryptionKeyListResponse describeUserEncryptionKeyListResponse = new DescribeUserEncryptionKeyListResponse();

			describeUserEncryptionKeyListResponse.HttpResponse = _ctx.HttpResponse;
			describeUserEncryptionKeyListResponse.RequestId = _ctx.StringValue("DescribeUserEncryptionKeyList.RequestId");

			DescribeUserEncryptionKeyListResponse.DescribeUserEncryptionKeyList_Data data = new DescribeUserEncryptionKeyListResponse.DescribeUserEncryptionKeyList_Data();

			List<string> data_keyIds = new List<string>();
			for (int i = 0; i < _ctx.Length("DescribeUserEncryptionKeyList.Data.KeyIds.Length"); i++) {
				data_keyIds.Add(_ctx.StringValue("DescribeUserEncryptionKeyList.Data.KeyIds["+ i +"]"));
			}
			data.KeyIds = data_keyIds;
			describeUserEncryptionKeyListResponse.Data = data;
        
			return describeUserEncryptionKeyListResponse;
        }
    }
}
