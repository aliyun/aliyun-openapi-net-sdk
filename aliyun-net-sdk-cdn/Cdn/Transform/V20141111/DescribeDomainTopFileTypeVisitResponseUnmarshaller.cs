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
using Aliyun.Acs.Cdn.Model.V20141111;
using System;
using System.Collections.Generic;

namespace Aliyun.Acs.Cdn.Transform.V20141111
{
    public class DescribeDomainTopFileTypeVisitResponseUnmarshaller
    {
        public static DescribeDomainTopFileTypeVisitResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeDomainTopFileTypeVisitResponse describeDomainTopFileTypeVisitResponse = new DescribeDomainTopFileTypeVisitResponse();

			describeDomainTopFileTypeVisitResponse.HttpResponse = context.HttpResponse;
			describeDomainTopFileTypeVisitResponse.RequestId = context.StringValue("DescribeDomainTopFileTypeVisit.RequestId");
			describeDomainTopFileTypeVisitResponse.DomainName = context.StringValue("DescribeDomainTopFileTypeVisit.DomainName");
			describeDomainTopFileTypeVisitResponse.StartTime = context.StringValue("DescribeDomainTopFileTypeVisit.StartTime");

			List<DescribeDomainTopFileTypeVisitResponse.FileTypeList> topFileTypeList = new List<DescribeDomainTopFileTypeVisitResponse.FileTypeList>();
			for (int i = 0; i < context.Length("DescribeDomainTopFileTypeVisit.TopFileTypeList.Length"); i++) {
				DescribeDomainTopFileTypeVisitResponse.FileTypeList fileTypeList = new DescribeDomainTopFileTypeVisitResponse.FileTypeList();
				fileTypeList.FileTypeDetail = context.StringValue("DescribeDomainTopFileTypeVisit.TopFileTypeList["+ i +"].FileTypeDetail");
				fileTypeList.VisitData = context.StringValue("DescribeDomainTopFileTypeVisit.TopFileTypeList["+ i +"].VisitData");

				topFileTypeList.Add(fileTypeList);
			}
			describeDomainTopFileTypeVisitResponse.TopFileTypeList = topFileTypeList;
        
			return describeDomainTopFileTypeVisitResponse;
        }
    }
}