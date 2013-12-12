﻿/*jslint unparam: true, white: true, browser: true, devel: true */
/*global bettercms */

bettercms.define('bcms.pages.filter', ['bcms.jquery', 'bcms', 'bcms.ko.extenders', 'bcms.tags'],
    function($, bcms, ko, tags) {
        'use strict';

        var filter = {},
            selectors = {
                filterTemplate: '#bcms-filter-template',
                filterCategory: '#bcms-filter-category-selection',
                filterCulture: '#bcms-filter-culture-selection',
            },
            links = {},
            globalization = {};

        /**
        * Assign objects to module.
        */
        filter.links = links;
        filter.globalization = globalization;

        function FilterViewModel(tagsViewModel, container, onSearchClick) {
            var self = this;

            self.isVisible = ko.observable(false);
            self.tags = tagsViewModel;
            self.includeArchived = ko.observable(false);
            self.includeMasterPages = ko.observable(false);
            
            // Initialize categories drop down
            self.categoryDropDown = container.find(selectors.filterCategory).get(0);
            var categoryDropDownValue = 0;
            if ($(self.categoryDropDown).get(0) && $(self.categoryDropDown).get(0).selectedIndex) {
                categoryDropDownValue = $(self.categoryDropDown).get(0).selectedIndex;
            }
            self.categoryDropDownValue = ko.observable(categoryDropDownValue);
            $(self.categoryDropDown).change(function () {
                self.categoryDropDownValue(this.selectedIndex);
            });

            // Initialize cultures drop down
            self.cultureDropDown = container.find(selectors.filterCulture).get(0);
            self.cultureDropDownValue = ko.observable(0);
            if (self.cultureDropDown) {
                var cultureDropDownValue = 0;
                if ($(self.cultureDropDown).get(0) && $(self.cultureDropDown).get(0).selectedIndex) {
                    cultureDropDownValue = $(self.cultureDropDown).get(0).selectedIndex;
                }
                self.cultureDropDownValue = ko.observable(cultureDropDownValue);
                $(self.cultureDropDown).change(function() {
                    self.cultureDropDownValue(this.selectedIndex);
                });
            }

            self.isEdited = ko.computed(function () {
                if (self.includeArchived()) {
                    return true;
                }
                if (self.includeMasterPages()) {
                    return true;
                }
                if (self.tags != null && self.tags.items() != null && self.tags.items().length > 0) {
                    return true;
                }
                if (self.categoryDropDownValue() != 0) {
                    return true;
                }
                if (self.cultureDropDownValue() != 0) {
                    return true;
                }
                return false;
            });

            // Actions.
            self.toggleFilter = function() {
                self.isVisible(!self.isVisible());
            };
            self.closeFilter = function () {
                self.isVisible(false);
            };
            self.searchWithFilter = function () {
                if ($.isFunction(onSearchClick)) {
                    onSearchClick();
                }
            };
            self.clearFilter = function () {
                self.tags.items([]);
                self.includeArchived(false);
                self.includeMasterPages(false);
                self.categoryDropDownValue(0);
                if (self.categoryDropDown) {
                    self.categoryDropDown.selectedIndex = 0;
                }
                self.cultureDropDownValue(0);
                if (self.cultureDropDown) {
                    self.cultureDropDown.selectedIndex = 0;
                }
                self.searchWithFilter();
            };
            self.changeIncludeArchived = function () {
                self.includeArchived(!(self.includeArchived()));
            };
            self.changeIncludeMasterPages = function () {
                self.includeMasterPages(!(self.includeMasterPages()));
            };
        }

        filter.bind = function (container, jsonData, onSearchClick) {
            var tagsViewModel = new tags.TagsListViewModel(jsonData.Tags),
                filterViewModel = new FilterViewModel(tagsViewModel, container, onSearchClick);
            filterViewModel.includeArchived(jsonData.IncludeArchived ? true : false);
            filterViewModel.includeMasterPages(jsonData.IncludeMasterPages ? true : false);
            ko.applyBindings(filterViewModel, container.find(selectors.filterTemplate).get(0));
        };

        /**
        * Initializes page module.
        */
        filter.init = function() {
            bcms.logger.debug('Initializing bcms.pages.filter module.');
        };

        /**
        * Register initialization
        */
        bcms.registerInit(filter.init);

        return filter;
    });
