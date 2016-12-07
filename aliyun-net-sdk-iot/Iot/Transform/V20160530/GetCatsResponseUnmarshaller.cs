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
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Iot.Model.V20160530;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Iot.Transform.V20160530
{
    public class GetCatsResponseUnmarshaller
    {
        public static GetCatsResponse Unmarshall(UnmarshallerContext context)
        {
			GetCatsResponse getCatsResponse = new GetCatsResponse();

			getCatsResponse.HttpResponse = context.HttpResponse;
			getCatsResponse.RequestId = context.StringValue("GetCats.RequestId");
			getCatsResponse.Success = context.BooleanValue("GetCats.Success");
			getCatsResponse.ErrorMessage = context.StringValue("GetCats.ErrorMessage");

			GetCatsResponse.CatInfo_ catInfo = new GetCatsResponse.CatInfo_();
			catInfo.Id = context.LongValue("GetCats.CatInfo.Id");
			catInfo.Name = context.StringValue("GetCats.CatInfo.Name");
			catInfo.HasChild = context.BooleanValue("GetCats.CatInfo.HasChild");

			List<GetCatsResponse.CatInfo_.ChildCat> childs = new List<GetCatsResponse.CatInfo_.ChildCat>();
			for (int i = 0; i < context.Length("GetCats.CatInfo.Childs.Length"); i++) {
				GetCatsResponse.CatInfo_.ChildCat childCat = new GetCatsResponse.CatInfo_.ChildCat();
				childCat.Id = context.LongValue("GetCats.CatInfo.Childs["+ i +"].Id");
				childCat.Name = context.StringValue("GetCats.CatInfo.Childs["+ i +"].Name");
				childCat.HasChild = context.BooleanValue("GetCats.CatInfo.Childs["+ i +"].HasChild");

				childs.Add(childCat);
			}
			catInfo.Childs = childs;
			getCatsResponse.CatInfo = catInfo;
        
			return getCatsResponse;
        }
    }
}