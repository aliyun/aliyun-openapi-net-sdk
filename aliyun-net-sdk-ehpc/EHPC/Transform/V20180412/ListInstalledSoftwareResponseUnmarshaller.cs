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
using Aliyun.Acs.EHPC.Model.V20180412;

namespace Aliyun.Acs.EHPC.Transform.V20180412
{
    public class ListInstalledSoftwareResponseUnmarshaller
    {
        public static ListInstalledSoftwareResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListInstalledSoftwareResponse listInstalledSoftwareResponse = new ListInstalledSoftwareResponse();

			listInstalledSoftwareResponse.HttpResponse = _ctx.HttpResponse;
			listInstalledSoftwareResponse.RequestId = _ctx.StringValue("ListInstalledSoftware.RequestId");

			List<ListInstalledSoftwareResponse.ListInstalledSoftware_SoftwareListItem> listInstalledSoftwareResponse_softwareList = new List<ListInstalledSoftwareResponse.ListInstalledSoftware_SoftwareListItem>();
			for (int i = 0; i < _ctx.Length("ListInstalledSoftware.SoftwareList.Length"); i++) {
				ListInstalledSoftwareResponse.ListInstalledSoftware_SoftwareListItem softwareListItem = new ListInstalledSoftwareResponse.ListInstalledSoftware_SoftwareListItem();
				softwareListItem.SoftwareId = _ctx.StringValue("ListInstalledSoftware.SoftwareList["+ i +"].SoftwareId");
				softwareListItem.SoftwareName = _ctx.StringValue("ListInstalledSoftware.SoftwareList["+ i +"].SoftwareName");
				softwareListItem.SoftwareVersion = _ctx.StringValue("ListInstalledSoftware.SoftwareList["+ i +"].SoftwareVersion");
				softwareListItem.SoftwareStatus = _ctx.StringValue("ListInstalledSoftware.SoftwareList["+ i +"].SoftwareStatus");

				listInstalledSoftwareResponse_softwareList.Add(softwareListItem);
			}
			listInstalledSoftwareResponse.SoftwareList = listInstalledSoftwareResponse_softwareList;
        
			return listInstalledSoftwareResponse;
        }
    }
}
