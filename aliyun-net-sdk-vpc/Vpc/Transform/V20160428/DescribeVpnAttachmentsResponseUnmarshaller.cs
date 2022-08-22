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
using Aliyun.Acs.Vpc.Model.V20160428;

namespace Aliyun.Acs.Vpc.Transform.V20160428
{
    public class DescribeVpnAttachmentsResponseUnmarshaller
    {
        public static DescribeVpnAttachmentsResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeVpnAttachmentsResponse describeVpnAttachmentsResponse = new DescribeVpnAttachmentsResponse();

			describeVpnAttachmentsResponse.HttpResponse = _ctx.HttpResponse;
			describeVpnAttachmentsResponse.RequestId = _ctx.StringValue("DescribeVpnAttachments.RequestId");
			describeVpnAttachmentsResponse.PageSize = _ctx.IntegerValue("DescribeVpnAttachments.PageSize");
			describeVpnAttachmentsResponse.PageNumber = _ctx.IntegerValue("DescribeVpnAttachments.PageNumber");
			describeVpnAttachmentsResponse.TotalCount = _ctx.IntegerValue("DescribeVpnAttachments.TotalCount");

			List<DescribeVpnAttachmentsResponse.DescribeVpnAttachments_VpnAttachment> describeVpnAttachmentsResponse_vpnAttachments = new List<DescribeVpnAttachmentsResponse.DescribeVpnAttachments_VpnAttachment>();
			for (int i = 0; i < _ctx.Length("DescribeVpnAttachments.VpnAttachments.Length"); i++) {
				DescribeVpnAttachmentsResponse.DescribeVpnAttachments_VpnAttachment vpnAttachment = new DescribeVpnAttachmentsResponse.DescribeVpnAttachments_VpnAttachment();
				vpnAttachment.InstanceId = _ctx.StringValue("DescribeVpnAttachments.VpnAttachments["+ i +"].InstanceId");
				vpnAttachment.Name = _ctx.StringValue("DescribeVpnAttachments.VpnAttachments["+ i +"].Name");
				vpnAttachment.Description = _ctx.StringValue("DescribeVpnAttachments.VpnAttachments["+ i +"].Description");
				vpnAttachment.AttachType = _ctx.StringValue("DescribeVpnAttachments.VpnAttachments["+ i +"].AttachType");
				vpnAttachment.TransitRouterId = _ctx.StringValue("DescribeVpnAttachments.VpnAttachments["+ i +"].TransitRouterId");
				vpnAttachment.TransitRouterName = _ctx.StringValue("DescribeVpnAttachments.VpnAttachments["+ i +"].TransitRouterName");
				vpnAttachment.CrossAccountAuthorized = _ctx.BooleanValue("DescribeVpnAttachments.VpnAttachments["+ i +"].CrossAccountAuthorized");

				describeVpnAttachmentsResponse_vpnAttachments.Add(vpnAttachment);
			}
			describeVpnAttachmentsResponse.VpnAttachments = describeVpnAttachmentsResponse_vpnAttachments;
        
			return describeVpnAttachmentsResponse;
        }
    }
}
