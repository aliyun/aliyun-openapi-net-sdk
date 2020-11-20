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
using Aliyun.Acs.Green.Model.V20170823;

namespace Aliyun.Acs.Green.Transform.V20170823
{
    public class DescribeImageLibResponseUnmarshaller
    {
        public static DescribeImageLibResponse Unmarshall(UnmarshallerContext _ctx)
        {
			DescribeImageLibResponse describeImageLibResponse = new DescribeImageLibResponse();

			describeImageLibResponse.HttpResponse = _ctx.HttpResponse;
			describeImageLibResponse.RequestId = _ctx.StringValue("DescribeImageLib.RequestId");
			describeImageLibResponse.TotalCount = _ctx.IntegerValue("DescribeImageLib.TotalCount");

			List<DescribeImageLibResponse.DescribeImageLib_ImageLib> describeImageLibResponse_imageLibList = new List<DescribeImageLibResponse.DescribeImageLib_ImageLib>();
			for (int i = 0; i < _ctx.Length("DescribeImageLib.ImageLibList.Length"); i++) {
				DescribeImageLibResponse.DescribeImageLib_ImageLib imageLib = new DescribeImageLibResponse.DescribeImageLib_ImageLib();
				imageLib.ImageCount = _ctx.IntegerValue("DescribeImageLib.ImageLibList["+ i +"].ImageCount");
				imageLib.ModifiedTime = _ctx.StringValue("DescribeImageLib.ImageLibList["+ i +"].ModifiedTime");
				imageLib.Code = _ctx.StringValue("DescribeImageLib.ImageLibList["+ i +"].Code");
				imageLib.Name = _ctx.StringValue("DescribeImageLib.ImageLibList["+ i +"].Name");
				imageLib.Id = _ctx.IntegerValue("DescribeImageLib.ImageLibList["+ i +"].Id");
				imageLib.Source = _ctx.StringValue("DescribeImageLib.ImageLibList["+ i +"].Source");
				imageLib.Category = _ctx.StringValue("DescribeImageLib.ImageLibList["+ i +"].Category");
				imageLib.ServiceModule = _ctx.StringValue("DescribeImageLib.ImageLibList["+ i +"].ServiceModule");
				imageLib.Scene = _ctx.StringValue("DescribeImageLib.ImageLibList["+ i +"].Scene");
				imageLib.Enable = _ctx.StringValue("DescribeImageLib.ImageLibList["+ i +"].Enable");

				List<string> imageLib_bizTypes = new List<string>();
				for (int j = 0; j < _ctx.Length("DescribeImageLib.ImageLibList["+ i +"].BizTypes.Length"); j++) {
					imageLib_bizTypes.Add(_ctx.StringValue("DescribeImageLib.ImageLibList["+ i +"].BizTypes["+ j +"]"));
				}
				imageLib.BizTypes = imageLib_bizTypes;

				describeImageLibResponse_imageLibList.Add(imageLib);
			}
			describeImageLibResponse.ImageLibList = describeImageLibResponse_imageLibList;
        
			return describeImageLibResponse;
        }
    }
}
