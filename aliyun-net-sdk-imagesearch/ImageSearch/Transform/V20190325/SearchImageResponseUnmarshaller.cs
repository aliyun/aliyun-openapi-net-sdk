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
using Aliyun.Acs.ImageSearch.Model.V20190325;

namespace Aliyun.Acs.ImageSearch.Transform.V20190325
{
    public class SearchImageResponseUnmarshaller
    {
        public static SearchImageResponse Unmarshall(UnmarshallerContext context)
        {
			SearchImageResponse searchImageResponse = new SearchImageResponse();

			searchImageResponse.HttpResponse = context.HttpResponse;
			searchImageResponse.RequestId = context.StringValue("SearchImage.RequestId");
			searchImageResponse.Success = context.BooleanValue("SearchImage.Success");
			searchImageResponse.Code = context.IntegerValue("SearchImage.Code");
			searchImageResponse.Msg = context.StringValue("SearchImage.Msg");

			SearchImageResponse.SearchImage_Head head = new SearchImageResponse.SearchImage_Head();
			head.DocsReturn = context.IntegerValue("SearchImage.Head.DocsReturn");
			head.DocsFound = context.IntegerValue("SearchImage.Head.DocsFound");
			head.SearchTime = context.IntegerValue("SearchImage.Head.SearchTime");
			searchImageResponse.Head = head;

			SearchImageResponse.SearchImage_PicInfo picInfo = new SearchImageResponse.SearchImage_PicInfo();
			picInfo.CategoryId = context.IntegerValue("SearchImage.PicInfo.CategoryId");
			picInfo.Region = context.StringValue("SearchImage.PicInfo.Region");

			List<SearchImageResponse.SearchImage_PicInfo.SearchImage_Category> picInfo_allCategories = new List<SearchImageResponse.SearchImage_PicInfo.SearchImage_Category>();
			for (int i = 0; i < context.Length("SearchImage.PicInfo.AllCategories.Length"); i++) {
				SearchImageResponse.SearchImage_PicInfo.SearchImage_Category category = new SearchImageResponse.SearchImage_PicInfo.SearchImage_Category();
				category.Id = context.IntegerValue("SearchImage.PicInfo.AllCategories["+ i +"].Id");
				category.Name = context.StringValue("SearchImage.PicInfo.AllCategories["+ i +"].Name");

				picInfo_allCategories.Add(category);
			}
			picInfo.AllCategories = picInfo_allCategories;
			searchImageResponse.PicInfo = picInfo;

			List<SearchImageResponse.SearchImage_Auction> searchImageResponse_auctions = new List<SearchImageResponse.SearchImage_Auction>();
			for (int i = 0; i < context.Length("SearchImage.Auctions.Length"); i++) {
				SearchImageResponse.SearchImage_Auction auction = new SearchImageResponse.SearchImage_Auction();
				auction.CategoryId = context.IntegerValue("SearchImage.Auctions["+ i +"].CategoryId");
				auction.ProductId = context.StringValue("SearchImage.Auctions["+ i +"].ProductId");
				auction.PicName = context.StringValue("SearchImage.Auctions["+ i +"].PicName");
				auction.CustomContent = context.StringValue("SearchImage.Auctions["+ i +"].CustomContent");
				auction.SortExprValues = context.StringValue("SearchImage.Auctions["+ i +"].SortExprValues");
				auction.IntAttr = context.IntegerValue("SearchImage.Auctions["+ i +"].IntAttr");
				auction.StrAttr = context.StringValue("SearchImage.Auctions["+ i +"].StrAttr");

				searchImageResponse_auctions.Add(auction);
			}
			searchImageResponse.Auctions = searchImageResponse_auctions;
        
			return searchImageResponse;
        }
    }
}
