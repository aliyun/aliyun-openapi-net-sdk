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
using Aliyun.Acs.gpdb.Model.V20160503;

namespace Aliyun.Acs.gpdb.Transform.V20160503
{
    public class DescribeSpecificationResponseUnmarshaller
    {
        public static DescribeSpecificationResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeSpecificationResponse describeSpecificationResponse = new DescribeSpecificationResponse();

			describeSpecificationResponse.HttpResponse = _ctx.HttpResponse;
			describeSpecificationResponse.RequestId = _ctx.StringValue("DescribeSpecification.RequestId");

			List<DescribeSpecificationResponse.DescribeSpecification_StorageNoticeItem> describeSpecificationResponse_storageNotice = new List<DescribeSpecificationResponse.DescribeSpecification_StorageNoticeItem>();
			for (int i = 0; i < _ctx.Length("DescribeSpecification.StorageNotice.Length"); i++) {
				DescribeSpecificationResponse.DescribeSpecification_StorageNoticeItem storageNoticeItem = new DescribeSpecificationResponse.DescribeSpecification_StorageNoticeItem();
				storageNoticeItem._Value = _ctx.StringValue("DescribeSpecification.StorageNotice["+ i +"].Value");
				storageNoticeItem.Text = _ctx.StringValue("DescribeSpecification.StorageNotice["+ i +"].Text");

				describeSpecificationResponse_storageNotice.Add(storageNoticeItem);
			}
			describeSpecificationResponse.StorageNotice = describeSpecificationResponse_storageNotice;

			List<DescribeSpecificationResponse.DescribeSpecification_DBInstanceClassItem> describeSpecificationResponse_dBInstanceClass = new List<DescribeSpecificationResponse.DescribeSpecification_DBInstanceClassItem>();
			for (int i = 0; i < _ctx.Length("DescribeSpecification.DBInstanceClass.Length"); i++) {
				DescribeSpecificationResponse.DescribeSpecification_DBInstanceClassItem dBInstanceClassItem = new DescribeSpecificationResponse.DescribeSpecification_DBInstanceClassItem();
				dBInstanceClassItem._Value = _ctx.StringValue("DescribeSpecification.DBInstanceClass["+ i +"].Value");
				dBInstanceClassItem.Text = _ctx.StringValue("DescribeSpecification.DBInstanceClass["+ i +"].Text");

				describeSpecificationResponse_dBInstanceClass.Add(dBInstanceClassItem);
			}
			describeSpecificationResponse.DBInstanceClass = describeSpecificationResponse_dBInstanceClass;

			List<DescribeSpecificationResponse.DescribeSpecification_DBInstanceGroupCountItem> describeSpecificationResponse_dBInstanceGroupCount = new List<DescribeSpecificationResponse.DescribeSpecification_DBInstanceGroupCountItem>();
			for (int i = 0; i < _ctx.Length("DescribeSpecification.DBInstanceGroupCount.Length"); i++) {
				DescribeSpecificationResponse.DescribeSpecification_DBInstanceGroupCountItem dBInstanceGroupCountItem = new DescribeSpecificationResponse.DescribeSpecification_DBInstanceGroupCountItem();
				dBInstanceGroupCountItem._Value = _ctx.StringValue("DescribeSpecification.DBInstanceGroupCount["+ i +"].Value");
				dBInstanceGroupCountItem.Text = _ctx.StringValue("DescribeSpecification.DBInstanceGroupCount["+ i +"].Text");

				describeSpecificationResponse_dBInstanceGroupCount.Add(dBInstanceGroupCountItem);
			}
			describeSpecificationResponse.DBInstanceGroupCount = describeSpecificationResponse_dBInstanceGroupCount;
        
			return describeSpecificationResponse;
        }
    }
}
