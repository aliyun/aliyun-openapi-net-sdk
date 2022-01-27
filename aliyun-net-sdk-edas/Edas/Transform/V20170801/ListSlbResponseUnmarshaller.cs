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
using Aliyun.Acs.Edas.Model.V20170801;

namespace Aliyun.Acs.Edas.Transform.V20170801
{
    public class ListSlbResponseUnmarshaller
    {
        public static ListSlbResponse Unmarshall(UnmarshallerContext _ctx)
        {
			ListSlbResponse listSlbResponse = new ListSlbResponse();

			listSlbResponse.HttpResponse = _ctx.HttpResponse;
			listSlbResponse.Code = _ctx.IntegerValue("ListSlb.Code");
			listSlbResponse.Message = _ctx.StringValue("ListSlb.Message");
			listSlbResponse.RequestId = _ctx.StringValue("ListSlb.RequestId");

			List<ListSlbResponse.ListSlb_SlbEntity> listSlbResponse_slbList = new List<ListSlbResponse.ListSlb_SlbEntity>();
			for (int i = 0; i < _ctx.Length("ListSlb.SlbList.Length"); i++) {
				ListSlbResponse.ListSlb_SlbEntity slbEntity = new ListSlbResponse.ListSlb_SlbEntity();
				slbEntity.SlbId = _ctx.StringValue("ListSlb.SlbList["+ i +"].SlbId");
				slbEntity.SlbName = _ctx.StringValue("ListSlb.SlbList["+ i +"].SlbName");
				slbEntity.RegionId = _ctx.StringValue("ListSlb.SlbList["+ i +"].RegionId");
				slbEntity.UserId = _ctx.StringValue("ListSlb.SlbList["+ i +"].UserId");
				slbEntity.Address = _ctx.StringValue("ListSlb.SlbList["+ i +"].Address");
				slbEntity.SlbStatus = _ctx.StringValue("ListSlb.SlbList["+ i +"].SlbStatus");
				slbEntity.AddressType = _ctx.StringValue("ListSlb.SlbList["+ i +"].AddressType");
				slbEntity.VswitchId = _ctx.StringValue("ListSlb.SlbList["+ i +"].VswitchId");
				slbEntity.VpcId = _ctx.StringValue("ListSlb.SlbList["+ i +"].VpcId");
				slbEntity.NetworkType = _ctx.StringValue("ListSlb.SlbList["+ i +"].NetworkType");
				slbEntity.GroupId = _ctx.IntegerValue("ListSlb.SlbList["+ i +"].GroupId");
				slbEntity.Expired = _ctx.BooleanValue("ListSlb.SlbList["+ i +"].Expired");

				listSlbResponse_slbList.Add(slbEntity);
			}
			listSlbResponse.SlbList = listSlbResponse_slbList;
        
			return listSlbResponse;
        }
    }
}
